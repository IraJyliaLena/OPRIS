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

namespace PetShop
{
    public partial class frmBreeds : Form
    {
        private SqlConnection myConnection;
        public frmBreeds(SqlConnection con)
        {
            InitializeComponent();

            myConnection = con;
            //dgvp = _dgvp;
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
            fillTheTable(dgvBreeds, "DISPLAY_BREEDS");
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
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        int GetKolBreeds(int id)
        {
            int kol = 0;
            string query = @"select count(breed_id) from Pets where breed_id = '{0}'";
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
                    cmd.CommandText = string.Format(query, id);
                    object value = cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    kol = Convert.ToInt32(value.ToString());
                }
                return kol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return kol;
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            int kol = GetKolBreeds(Convert.ToInt32(dgvBreeds.SelectedCells[0].Value));
            if (kol == 0)
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
                var sqlCmd = new SqlCommand("delete_from_breed", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvBreeds.SelectedCells[0].Value));
                sqlCmd.ExecuteNonQuery();
                fillTheTable(dgvBreeds, "DISPLAY_BREEDS");
            }
            else MessageBox.Show("Данную породу удалить невозможно.");   
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            frmBreedsACD br1 = new frmBreedsACD(myConnection, "add", dgvBreeds, null);
            br1.ShowDialog();
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

        private void butChange_Click(object sender, EventArgs e)
        {
            frmBreedsACD br1 = new frmBreedsACD(myConnection, "change", dgvBreeds, dgvBreeds.SelectedCells);
            //this.Hide();
            br1.ShowDialog();
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


    }
}
