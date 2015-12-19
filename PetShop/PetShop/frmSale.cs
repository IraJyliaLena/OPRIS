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
using System.Drawing.Printing;
using System.Reflection;

namespace PetShop
{
    
    public partial class frmSale : Form
    {
        public string ConnectionString { get; set; }
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        BindingSource bindingSource;
        DataTable table;
        private SqlConnection myConnection;
        private SqlConnection con;
        private String user_name;
        private DataGridView dgvp;
        string text;
        public frmSale(SqlConnection con, String User_Name,DataGridView _dgvp)
        {
            InitializeComponent();
            myConnection = con;
            fillTheTable(dgvPets, "DISPLAY_UNSOLD_PETS");
            user_name = User_Name;
            dgvp = _dgvp;
        }

        private void fillTheTable(DataGridView dgv, string commandText)
        {
            string connectionString = @"Data Source=.;Initial Catalog=PetShopO;user id=sa; password=1;";
            myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand comm = new SqlCommand(commandText, myConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv.DataSource = bs;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            fillTheTable(dgvp, "DISPLAY_UNSOLD_PETS");
            this.Owner.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {

            Int64 pas = 0;
            string query = @"select employee_id from Employees where employee_surname = '{0}'";
            try
            {
                string connectionString = @"Data Source=.;Initial Catalog=PetShopO;user id=sa; password=1;";
                myConnection = new SqlConnection(connectionString);
                try
                {
                    myConnection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
                using (var cmd = myConnection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format(query, user_name);
                    object value = cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    pas = Convert.ToInt64(value.ToString());
                }
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
               // SqlConnection con = new SqlConnection(ConnectionString);
                string connectionString = @"Data Source=.;Initial Catalog=PetShopO;user id=sa; password=1;";
                con = new SqlConnection(connectionString);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    
                    cmd.CommandText = "sell_pet";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    DateTime date = new DateTime();
                    date = DateTime.Now;
                    String IDPets = dgvPets.SelectedCells[0].Value.ToString();
                    int IDP = Convert.ToInt32(IDPets);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@cashierID", pas);
                    cmd.Parameters.AddWithValue("@pet_ID", IDP);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
               
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.Hide();
            //this.Owner.Show();

            
            Word.Application ap = new Word.Application();
            try
            {

                //Word.Document doc = ap.Documents.Open(@"C:\Users\Юляха\Documents\Учеба, мехмат\4 курс\ОПРИС.doc", ReadOnly: false, Visible: false);
                //Word.Document doc = ap.Documents.Open(@"C:\Users\Лена\Desktop\7 семестр\ОПРИС\чек.doc");
                Word.Document doc = ap.Documents.Open(@"C:\Users\Ирина\Desktop\Разные документы\Чек.docx");
                doc.Activate();

                Word.Selection sel = ap.Selection;

                if (sel != null)
                {
                    switch (sel.Type)
                    {
                        case Word.WdSelectionType.wdSelectionIP:
                            sel.TypeText(DateTime.Now.ToString());
                            sel.TypeParagraph();
                            sel.TypeText("Магазин животных МОХНАТУЛИЧКА");
                            sel.TypeParagraph();
                            sel.TypeText(dgvPets.SelectedCells[5].Value.ToString() + " (" + dgvPets.SelectedCells[6].Value.ToString() + ") "+dgvPets.SelectedCells[1].Value.ToString());
                            //sel.TypeText(dgvPets.SelectedCells[1].Value.ToString()+ "    "+dgvPets.SelectedCells[4].Value.ToString()+"    "+dgvPets.SelectedCells[5].Value.ToString());
                            sel.TypeParagraph();
                            sel.TypeText("Цена: "+dgvPets.SelectedCells[4].Value.ToString()+" рублей");
                            sel.TypeParagraph();
                            sel.TypeText("Подпись продавца:____________________________\n");
                            break;

                        default:
                            Console.WriteLine("Selection type not handled; no writing done");
                            break;

                    }
                    text = "          \n\n\n";
                    text = "\n          " + DateTime.Now.ToString()+"\n";
                    text = text + "          Магазин животных МОХНАТУЛИЧКА\n";
                    text = text + "         " + dgvPets.SelectedCells[5].Value.ToString() + " (" + dgvPets.SelectedCells[6].Value.ToString() + ") " + dgvPets.SelectedCells[1].Value.ToString() + "\n";
                    text = text + "          Цена: " + dgvPets.SelectedCells[4].Value.ToString() + " рублей\n";
                    text = text + "          Подпись продавца:____________________________\n";
                    // Remove all meta data.
                    doc.RemoveDocumentInformation(Word.WdRemoveDocInfoType.wdRDIAll);
                    // ПЕЧАТЬ ВОРДА, НАДО ПРОВЕРИТЬ НА ПРИНТЕРЕ
                    ap.Documents.Save(NoPrompt: true, OriginalFormat: true);
                    ap.Documents.Close(SaveChanges: true, OriginalFormat: false, RouteDocument: false);

                    //PrintDialog printDialog1 = new PrintDialog();
                    //printDialog1.ShowDialog();
                    //PrintDocument def = new PrintDocument();
                    //def.PrintPage += new PrintPageEventHandler(PRD);
                    //def.DocumentName = "Чек";
                    //def.PrinterSettings = printDialog1.PrinterSettings;
                    //def.Print();
                    
                  // ap.Documents.Save(NoPrompt: true, OriginalFormat: true);
                }
                else
                {
                    Console.WriteLine("Unable to acquire Selection...no writing to document done..");
                    ap.Documents.Close(SaveChanges: false, OriginalFormat: false, RouteDocument: false);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message); // Could be that the document is already open (/) or Word is in Memory(?)
            }
            finally
            {
                ((Word._Application)ap).Quit(SaveChanges: true, OriginalFormat: false, RouteDocument: false);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);
            }
            fillTheTable(dgvPets, "DISPLAY_UNSOLD_PETS");
            //this.Hide();
            //this.Owner.Show();
        }

        void PRD(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font drawFont = new Font("Arial", 16);
            g.DrawString(text, drawFont, new SolidBrush(Color.Black), 0, 0);
        }


        private void btnQ_Click(object sender, EventArgs e)
        {
            frmSelect selec = new frmSelect(myConnection, user_name,dgvp);
            this.Hide();
            selec.Show(this);
        }
    }
}
