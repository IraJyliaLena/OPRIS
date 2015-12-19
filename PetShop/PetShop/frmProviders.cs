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
        public frmProviders(SqlConnection con, DataGridView _dgvp, string title)
        {
            InitializeComponent();
            this.Text = title;
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
            switch (title)
            {
                case "Данные о поставщиках":
                    fillTheTable(dgvProviders, "DISPLAY_PROVIDER");
                    break;
                case "Данные о сотрудниках":
                    fillTheTable(dgvProviders, "DISPLAY_EMPLOYEES");
                    break;
                case "Данные о должностях":
                    fillTheTable(dgvProviders, "DISPLAY_POSTS");
                    break;
                case "Данные о животных":
                    fillTheTable(dgvProviders, "DISPLAY_UNSOLD_PETS");
                    break;                    
            }
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
            switch (this.Text)
            {
                case "Данные о поставщиках":
                    fillTheTable(dgvp, "DISPLAY_PROVIDER");
                    break;
                case "Данные о сотрудниках":
                    fillTheTable(dgvp, "DISPLAY_EMPLOYEES");
                    break;
                case "Данные о животных":
                    fillTheTable(dgvp, "DISPLAY_UNSOLD_PETS");
                    break;
            }
            this.Owner.Show();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Данные о поставщиках":
                    frmProvidersACD prov1 = new frmProvidersACD(myConnection, "add", dgvProviders, null);
                    prov1.ShowDialog();
                    break;
                case "Данные о сотрудниках":
                    frmEmployeesAC empl1 = new frmEmployeesAC(myConnection, "add", dgvProviders, null);
                    empl1.ShowDialog();
                    break;
                case "Данные о должностях":
                    frmPostsAC posts1 = new frmPostsAC(myConnection, "add", dgvProviders, null);
                    posts1.ShowDialog();
                    break;
                case "Данные о животных":
                    frmPets pets = new frmPets(myConnection, "add", dgvProviders, null);
                    pets.ShowDialog();
                    break;
            }
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
            switch (this.Text)
            {
                case "Данные о поставщиках":
                    frmProvidersACD prov1 = new frmProvidersACD(myConnection, "change", dgvProviders, dgvProviders.SelectedCells);
                    prov1.ShowDialog();
                    break;
                case "Данные о сотрудниках":
                    frmEmployeesAC empl1 = new frmEmployeesAC(myConnection, "change", dgvProviders, dgvProviders.SelectedCells);
                    empl1.ShowDialog();
                    break;
                case "Данные о должностях":
                    frmPostsAC posts1 = new frmPostsAC(myConnection, "change", dgvProviders, dgvProviders.SelectedCells);
                    posts1.ShowDialog();
                    break;
                case "Данные о животных":
                    frmPets pets1 = new frmPets(myConnection, "change", dgvProviders, dgvProviders.SelectedCells);
                    pets1.ShowDialog();
                    break;
            }
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
            switch (this.Text)
            {
                case "Данные о поставщиках":
                    fillTheTable(dgvp, "DISPLAY_PROVIDER");
                    break;
                case "Данные о сотрудниках":
                    fillTheTable(dgvp, "DISPLAY_EMPLOYEES");
                    break;
                case "Данные о животных":
                    fillTheTable(dgvp, "DISPLAY_UNSOLD_PETS");
                    break;
            }
            this.Owner.Show();
        }

        int GetKol(string query)
        {
            int kol = 0;
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
                    MessageBox.Show(ex.Message);
                }
                using (var cmd = myConnection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format(query);
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
            string query = "";
            switch (this.Text)
            {
                case "Данные о поставщиках":
                    query = @"select count(provider_id) from Breeds where provider_id = ";
                    break;
                case "Данные о сотрудниках":
                    query = @"select count(pet_id) from Pets where pet_id = ";
                    break;
                case "Данные о должностях":
                    query = @"select count(employee_id) from employees where post_id = ";
                    break;
                case "Данные о животных":
                    query = @"select count(employee_id) from employees where post_id = ";
                    break;
            }
            query = query + dgvProviders.SelectedCells[0].Value.ToString();
            int kol = GetKol(query);
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
                string nameProc = "";
                switch (this.Text)
                {
                    case "Данные о поставщиках":
                        nameProc = "delete_from_provider";
                        break;
                    case "Данные о сотрудниках":
                        nameProc = "delete_from_employee";
                        break;
                    case "Данные о должностях":
                        nameProc = "delete_from_posts";
                        break;
                    case "Данные о животных":
                        nameProc = "delete_from_pets";
                        break;
                }
                var sqlCmd = new SqlCommand(nameProc, myConnection);
                switch (this.Text)
                {
                    case "Данные о поставщиках":
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvProviders.SelectedCells[0].Value));
                        sqlCmd.ExecuteNonQuery();
                        fillTheTable(dgvProviders, "DISPLAY_PROVIDER");
                        break;
                    case "Данные о сотрудниках":
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvProviders.SelectedCells[0].Value));
                        sqlCmd.ExecuteNonQuery();
                        fillTheTable(dgvProviders, "DISPLAY_EMPLOYEES");
                        break;
                    case "Данные о должностях":
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvProviders.SelectedCells[0].Value));
                        sqlCmd.ExecuteNonQuery();
                        fillTheTable(dgvProviders, "DISPLAY_POSTS");
                        break;
                    case "Данные о животных":
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvProviders.SelectedCells[0].Value));
                        sqlCmd.ExecuteNonQuery();
                        fillTheTable(dgvProviders, "DISPLAY_UNSOLD_PETS");
                        break;
                }

            }
            else
            {
                switch (this.Text)
                {
                    case "Данные о поставщиках":
                        MessageBox.Show("Данного поставщика удалить невозможно.");
                        break;
                    case "Данные о сотрудниках":
                        MessageBox.Show("Данного сотрудника удалить невозможно.");
                        break;
                    case "Данные о должностях":
                        MessageBox.Show("Данную должность удалить невозможно.");
                        break;
                    case "Данные о животные":
                        MessageBox.Show("Данное животное удалить невозможно.");
                        break;
                }
            }
        }

        private void dgvProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
