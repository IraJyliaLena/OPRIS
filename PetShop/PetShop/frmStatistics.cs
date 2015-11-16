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

                //Word.Document doc = ap.Documents.Open(@"C:\Users\Юляха\Documents\Учеба, мехмат\4 курс\ОПРИС.doc", ReadOnly: false, Visible: false);
                Word.Document doc = ap.Documents.Add();
                doc.Activate();
 
                Word.Selection sel = ap.Selection;
 
                if (sel != null)
                {
                    switch (sel.Type)
                    {
                        case Word.WdSelectionType.wdSelectionIP:
                            sel.TypeText(DateTime.Now.ToString());
                            sel.TypeParagraph();
                            sel.TypeText("Microsoft Word");
                            sel.TypeParagraph();
                            break;
 
                        default:
                            Console.WriteLine("Selection type not handled; no writing done");
                            break;
 
                    }
 
                    // Remove all meta data.
                    doc.RemoveDocumentInformation(Word.WdRemoveDocInfoType.wdRDIAll);
 
                    ap.Documents.Save(NoPrompt: true, OriginalFormat: true);
                }
                else
                {
                    Console.WriteLine("Unable to acquire Selection...no writing to document done..");
                }
 
                ap.Documents.Close(SaveChanges: false, OriginalFormat: false, RouteDocument: false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message); // Could be that the document is already open (/) or Word is in Memory(?)
            }
            finally
            {   
                ((Word._Application)ap).Quit(SaveChanges: false, OriginalFormat: false, RouteDocument: false);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);
            }
        }
    }
}
