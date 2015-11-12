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
    public partial class frmCities : Form
    {
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        BindingSource bindingSource;
        DataTable table;
        private SqlConnection myConnection;
        public frmCities(SqlConnection con)
        {
            InitializeComponent();
            myConnection = con;
            GetData();
        }

        private void GetData()
        {
            bindingSource = new BindingSource();
            dgvCities.DataSource = bindingSource;
            try
            {
                dataAdapter = new SqlDataAdapter("select city_id AS 'Номер', city_name AS 'Город' from Cities", myConnection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при заполнении таблицы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butCansel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void frmCities_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private int Get_kol(string name)
        {
            int kol = 0;
            string query = "select count(city_id) from Cities where city_name = '{0}'";
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
            if (tbName.Text != "")
            {
                int kol = Get_kol(tbName.Text);
                if (kol > 0)
                {
                    MessageBox.Show("Такое значение в списке городов уже есть!");
                    tbName.Focus();
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
                    sqlCmd.Parameters.AddWithValue("@name", tbName.Text);
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
                tbName.Text = "";
                GetData();
            }            
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            frmAddCity changeCity = new frmAddCity("Изменить город", dgvCities.SelectedCells[1].Value.ToString());
            int id = Convert.ToInt32(dgvCities.SelectedCells[0].Value);
            changeCity.ShowDialog();
            string name = changeCity.value;
            if(name != "")
            {
                if (Get_kol(name) != 0)
                {
                    MessageBox.Show("Такое значение в списке городов уже есть!");
                    return;
                }
                else
                {
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
                            cmd.CommandText = string.Format("update Cities set city_name = '{0}' where city_id = '{1}'", name, id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                GetData();
            }
        }

        int GetKolProviders(int id)
        {
            int kol = 0;
            string query = @"select count(provider_id) from Providers where city_id = '{0}'";
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
            int kol = GetKolProviders(Convert.ToInt32(dgvCities.SelectedCells[0].Value));
            if (kol == 0)
            {
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
                        cmd.CommandText = string.Format("delete from Cities where city_id = '{0}'",Convert.ToInt32(dgvCities.SelectedCells[0].Value));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                GetData();
            }
            else MessageBox.Show("Данный город удалить невозможно!");       
        }
    }
}
