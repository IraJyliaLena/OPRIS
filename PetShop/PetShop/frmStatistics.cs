using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace PetShop
{
    public partial class frmStatistics : Form
    {
        private SqlConnection myConnection;
        private DateTime openDate = new DateTime(2014, 05, 01);

        public frmStatistics(SqlConnection con)
        {
            InitializeComponent();
            myConnection = con;
            dtFirstDate.Value = openDate;
            dtSecondDate.Value = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
            fillTheTable();
        }

        private void fillTheTable()
        {
            SqlCommand myCommand =new SqlCommand("DISPLAY_SOME_SOLD_PETS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter d1 = new SqlParameter("@date1", SqlDbType.NVarChar, 50);
            d1.Value = dtFirstDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d1);

            SqlParameter d2 = new SqlParameter("@date2", SqlDbType.NVarChar, 50);
            d2.Value = dtSecondDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            da.Fill(dt);
           
            dgvStats.DataSource = dt;

            lblProfit.Text = "Прибыль от продажи: " + getProfit() + " руб.";
        }

        private string getProfit()
        {
            SqlCommand myCommand = new SqlCommand("GET_PROFIT", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter d1 = new SqlParameter("@date1", SqlDbType.NVarChar, 50);
            d1.Value = dtFirstDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d1);

            SqlParameter d2 = new SqlParameter("@date2", SqlDbType.NVarChar, 50);
            d2.Value = dtSecondDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d2);

            SqlParameter profit = new SqlParameter("@profit", SqlDbType.Int, 10);
            profit.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(profit);

            myCommand.ExecuteNonQuery();

            return profit.Value.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            fillTheTable();
        }

        private void frmStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            myConnection.Close();
            this.Owner.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Word.Application ap = new Word.Application();
            try
            {
                String patternDir = Application.StartupPath;
                for (int i = 1; i <= 3; i++)
                    patternDir = patternDir.Remove(patternDir.LastIndexOf("\\"));
                Word.Document reportDoc = ap.Documents.Add(patternDir + "\\report_pattern.docx", Visible: false);
                reportDoc.Activate();
                Word.Selection sel = ap.Selection;

                if (sel != null)
                {
                    switch (sel.Type)
                    {
                        case Word.WdSelectionType.wdSelectionIP:
                            reportDoc.Tables[1].Rows[1].Cells[3].Range.Text = dtFirstDate.Text;
                            reportDoc.Tables[1].Rows[1].Cells[5].Range.Text = dtSecondDate.Text;
                            int countRows = dgvStats.RowCount;
                            for (int i = 2; i <= countRows; i++)
                            {
                                reportDoc.Tables[2].Rows.Add();
                                reportDoc.Tables[2].Rows[i].Cells[1].Range.Text = dgvStats.Rows[i-2].Cells[0].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[2].Range.Text = dgvStats.Rows[i-2].Cells[1].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[3].Range.Text = dgvStats.Rows[i-2].Cells[2].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[4].Range.Text = dgvStats.Rows[i-2].Cells[4].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[5].Range.Text = dgvStats.Rows[i-2].Cells[5].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[6].Range.Text = dgvStats.Rows[i-2].Cells[6].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[7].Range.Text = dgvStats.Rows[i-2].Cells[7].Value.ToString();
                                String saleDate = dgvStats.Rows[i-2].Cells[8].Value.ToString();
                                reportDoc.Tables[2].Rows[i].Cells[8].Range.Text = saleDate.Remove(saleDate.IndexOf(" "));
                                reportDoc.Tables[2].Rows[i].Cells[9].Range.Text = dgvStats.Rows[i-2].Cells[9].Value.ToString();
                            }
                            reportDoc.Tables[3].Rows[1].Cells[2].Range.Text = lblProfit.Text.Remove(0, lblProfit.Text.IndexOf(":") + 2);
                            reportDoc.Tables[3].Rows[2].Cells[2].Range.Text = DateTime.Now.ToString().Remove(DateTime.Now.ToString().IndexOf(" "));
                            break;

                        default:
                            Console.WriteLine("Selection type not handled; no writing done");
                            break;

                    }

                    // Remove all meta data.
                    reportDoc.RemoveDocumentInformation(Word.WdRemoveDocInfoType.wdRDIAll);
                    ap.Documents.Save(NoPrompt: true, OriginalFormat: true);
                }
                else
                {
                    Console.WriteLine("Unable to acquire Selection...no writing to document done..");
                }
                reportDoc.RemoveDocumentInformation(Word.WdRemoveDocInfoType.wdRDIAll);
                ap.Documents.Save(NoPrompt: true, OriginalFormat: true);
                ap.Documents.Close(SaveChanges: true, OriginalFormat: false, RouteDocument: false);
                MessageBox.Show("Отчет составлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message); // Could be that the document is already open (/) or Word is in Memory(?)
            }
            finally
            {
                try
                {
                    ((Word._Application)ap).Quit(SaveChanges: false, OriginalFormat: false);
                }
                catch { }
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);
            }
        }
    }
}
