using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmProviders : Form
    {
        private SqlConnection myConnection;
        DataGridView dgvp;
        public frmProviders(SqlConnection con, DataGridView _dgvp)
        {
            InitializeComponent();
            myConnection = con;
            dgvp = _dgvp;
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
            fillTheTable(dgvProviders, "DISPLAY_PROVIDER");
        }

        private void fillTheTable(DataGridView dgv, string commandText)
        {
            SqlCommand comm = new SqlCommand(commandText, myConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv.DataSource = bs;
        }

        private void frmProviders_Load(object sender, EventArgs e)
        {

        }

        private void frmProviders_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            fillTheTable(dgvp, "DISPLAY_PROVIDER");
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            frmProvidersACD prov1 = new frmProvidersACD(myConnection, "add", dgvProviders, null);
            prov1.ShowDialog();
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
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            frmProvidersACD prov1 = new frmProvidersACD(myConnection, "change", dgvProviders, dgvProviders.SelectedCells);
            this.Hide();
            prov1.ShowDialog(); 
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
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            fillTheTable(dgvp, "DISPLAY_PROVIDER");
        }

        private void butDel_Click(object sender, EventArgs e)
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
            var sqlCmd = new SqlCommand("delete_from_provider", myConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvProviders.SelectedCells[0].Value));
            sqlCmd.ExecuteNonQuery();
            fillTheTable(dgvProviders, "DISPLAY_PROVIDER");
        }
    }
}
