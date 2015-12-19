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
    public partial class frmBreedsACD : Form
    {
        private SqlConnection myConnection, con2;
        private DataSet myDS = new DataSet();
        private DataGridView dgvP;
        private DataGridViewSelectedCellCollection selcells = null;
        int id = 0;
        public frmBreedsACD(SqlConnection con, string fun, DataGridView d, DataGridViewSelectedCellCollection _selcells)
        {
            InitializeComponent();
            myConnection = con;
            selcells = _selcells;
            con2 = con;
            dgvP = d;
            fillComboBox();
            switch (fun)
            {
                case "add":
                    this.Text = "Добавить породу";
                    butAddNext.Visible = true;
                    break;
                case "change":
                    this.Text = "Изменить данные";
                    butAddNext.Visible = false;
                    break;
            }

        }

        private void fillComboBox()
        {
            string con = @"Data Source=.;Initial Catalog=PetShopO;user id=sa; password=1;";
            SqlDataAdapter da = new SqlDataAdapter("select provider_name from Providers Order by provider_name", con);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            cbProv.DataSource = tbl;
            cbProv.DisplayMember = "provider_name";
            SqlDataAdapter da1 = new SqlDataAdapter("select species_name from Species Order by species_name", con);
            DataTable tbl1 = new DataTable();
            da1.Fill(tbl1);
            cbSp.DataSource = tbl1;
            cbSp.DisplayMember = "species_name";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private int Get_kol(string name)
        {
            int kol = 0;
            string query = "select count(species_id) from Species where species_name = '{0}'";
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
                    cmd.CommandText = string.Format(query, name);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddSpec ac = new frmAddSpec("Добавить вид");
            ac.ShowDialog();
            string newSpec = ac.value;
            if (newSpec != "")
            {
                int kol = Get_kol(newSpec);
                if (kol > 0)
                {
                    MessageBox.Show("Такое значение в списке видов уже есть!");
                    //tbName.Focus();
                    return;
                }
                else
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
                    var sqlCmd = new SqlCommand("insert_into_species", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@name", newSpec);
                    sqlCmd.ExecuteNonQuery();
                }
                string connectionString1 = @"Data Source=.;Initial Catalog=PetShopO;user id=sa; password=1;";
                myConnection = new SqlConnection(connectionString1);
                try
                {
                    myConnection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
                fillComboBox();
                cbSp.Text = newSpec;
            }            
        }

        private void frmBreedsACD_Load(object sender, EventArgs e)
        {
            if (selcells != null)
            {
                id = Convert.ToInt32(selcells[0].Value);
                txtName.Text = selcells[1].Value.ToString();
                cbSp.Text = selcells[2].Value.ToString();
                cbProv.Text = selcells[3].Value.ToString();
                txtName.Focus();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            frmProvidersACD prov1 = new frmProvidersACD(myConnection, "add", dgv1, null);
            //prov1.Show(this);
            prov1.ShowDialog();
            //this.Hide();
            //fillTheTable(dgvP, "DISPLAY_BREEDS");
            fillComboBox();
            //cbProv.Text = newProv;
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

        private void doProc(String Sp, String Pr)
        {
            using (myConnection)
            {
                try
                {
                    string connectionString = @"Data Source=.;Initial Catalog=PetShopO;user id=sa; password=1;";
                    myConnection = new SqlConnection(connectionString);
                    myConnection.Open();
                }
                catch (SqlException ex)
                {

                }
                if(this.Text == "Добавить породу")
                {
                    var sqlCmd = new SqlCommand("insert_into_breed", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@sp", Sp);
                    sqlCmd.Parameters.AddWithValue("@pr", Pr);
                    sqlCmd.ExecuteNonQuery();
                } else
                {
                    var sqlCmd = new SqlCommand("update_breed", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@sp", Sp);
                    sqlCmd.Parameters.AddWithValue("@pr", Pr);
                    sqlCmd.ExecuteNonQuery();
                }    
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            doProc(cbSp.Text, cbProv.Text);
            this.Hide();
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
            fillTheTable(dgvP, "DISPLAY_BREEDS");
        }
        

        private void butAddNext_Click_1(object sender, EventArgs e)
        {
            doProc(cbSp.Text, cbProv.Text);
            txtName.Text = "";
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
            fillTheTable(dgvP, "DISPLAY_BREEDS");
        }
    }
}
