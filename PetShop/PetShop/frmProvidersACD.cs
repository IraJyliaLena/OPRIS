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
using System.Data.OleDb;

namespace PetShop
{
    public partial class frmProvidersACD : Form
    {
        private SqlConnection myConnection, con2;
        private DataSet myDS = new DataSet();
        private DataGridView dgvP;
        private DataGridViewSelectedCellCollection selcells = null;
        int id = 0;
        public frmProvidersACD(SqlConnection con, string fun, DataGridView d, DataGridViewSelectedCellCollection _selcells)
        {
            InitializeComponent();
            myConnection = con;
            selcells = _selcells;
            con2 = con;
            dgvP = d;
            fillCityBox();
            switch (fun)
            {
                case "add": 
                    this.Text = "Добавить поставщика";
                    butAddNext.Visible = true;
                    break;
                case "change":
                    this.Text = "Изменить данные";
                    butAddNext.Visible = false;
                    break;
            }
        }

        private void fillCityBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select city_name from Cities Order by city_name", myConnection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            cbCity.DataSource = tbl;
            cbCity.DisplayMember = "city_name";
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

        private void doProc(long phone, long account)
        {
            using (myConnection)
            {
                if(this.Text == "Добавить поставщика")
                {
                    var sqlCmd = new SqlCommand("insert_into_provider", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@nameProvider", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@phone", phone);
                    sqlCmd.Parameters.AddWithValue("@account", account);
                    sqlCmd.Parameters.AddWithValue("@cityName", cbCity.Text);
                    sqlCmd.ExecuteNonQuery();
                } else
                {
                    var sqlCmd = new SqlCommand("update_provider", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    sqlCmd.Parameters.AddWithValue("@nameProvider", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@phone", phone);
                    sqlCmd.Parameters.AddWithValue("@account", account);
                    sqlCmd.Parameters.AddWithValue("@cityName", cbCity.Text);
                    sqlCmd.ExecuteNonQuery();
                }    
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int lengthPhone = txtPhone.Text.Length;
            if (lengthPhone != 11)
            {
                MessageBox.Show("Некорректный номер телефона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }
            long phone = 0;
            try
            {
                phone = Convert.ToInt64(txtPhone.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некорректный номер телефона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }
            int lengthAccount = txtAccount.Text.Length;
            if (lengthAccount != 6)
            {
                MessageBox.Show("Некорректный номер счёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccount.Focus();
                return;
            }
            long account = 0;
            try
            {
                account = Convert.ToInt64(txtAccount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный номер счёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccount.Focus();
                return;
            }
            doProc(phone, account);
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
            fillTheTable(dgvP, "DISPLAY_PROVIDER");
        }

        private void frmProvidersACD_Load(object sender, EventArgs e)
        {
            if (selcells != null)
            {
                id = Convert.ToInt32(selcells[0].Value);
                txtName.Text = selcells[1].Value.ToString();
                txtPhone.Text = selcells[2].Value.ToString();
                txtAccount.Text = selcells[3].Value.ToString();
                cbCity.Text = selcells[4].Value.ToString();
                txtName.Focus();
            }
        }

        private int Get_kol(string name, string query1)
        {
            int kol = 0;
            string query = @query1;
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

        private void butAdd_Click(object sender, EventArgs e)
        {
            frmAddCity ac = new frmAddCity("Добавить город");
            ac.ShowDialog();
            string newCity = ac.value;
            if (newCity != "")
            {
                string query = "select count(city_id) from Cities where city_name = '{0}'";
                int kol = Get_kol(newCity, query);
                if (kol > 0)
                {
                    MessageBox.Show("Такое значение в списке городов уже есть!");
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
                    var sqlCmd = new SqlCommand("insert_into_cities", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@name", newCity);
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
                fillCityBox();
                cbCity.Text = newCity;
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void butAddNext_Click(object sender, EventArgs e)
        {
            int lengthPhone = txtPhone.Text.Length;
            if (lengthPhone != 11)
            {
                MessageBox.Show("Некорректный номер телефона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }
            long phone = 0;
            try
            {
                phone = Convert.ToInt64(txtPhone.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный номер телефона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }
            int lengthAccount = txtAccount.Text.Length;
            if (lengthAccount != 6)
            {
                MessageBox.Show("Некорректный номер счёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccount.Focus();
                return;
            }
            long account = 0;
            try
            {
                account = Convert.ToInt64(txtAccount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный номер счёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccount.Focus();
                return;
            }
            doProc(phone, account);
            txtName.Text = "";
            txtAccount.Text = "";
            txtPhone.Text = "";
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
            fillTheTable(dgvP, "DISPLAY_PROVIDER");
        }
    }
}
