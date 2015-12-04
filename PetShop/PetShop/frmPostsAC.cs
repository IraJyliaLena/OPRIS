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
    public partial class frmPostsAC : Form
    {
        private SqlConnection myConnection, con2;
        private DataSet myDS = new DataSet();
        private DataGridView dgvP;
        private DataGridViewSelectedCellCollection selcells = null;
        int id = 0;
        public frmPostsAC(SqlConnection con, string fun, DataGridView d, DataGridViewSelectedCellCollection _selcells)
        {
            InitializeComponent();
            myConnection = con;
            selcells = _selcells;
            con2 = con;
            dgvP = d;
            switch (fun)
            {
                case "add":
                    this.Text = "Добавить должность";
                    break;
                case "change":
                    this.Text = "Изменить должность";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private int Get_kol(string query1, string name)
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
                    MessageBox.Show(ex.Message); ;
                }
                using (var cmd = myConnection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format(query1,name);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            int salary;
            try
            {
                salary = Convert.ToInt32(txtSalary.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некорректная заработная плата!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalary.Focus();
                return;
            }
            using (myConnection)
            {
                if (this.Text == "Добавить должность")
                {
                    string query = @"select count(post_id) from Posts where post_name = '{0}'";
                    int kol = Get_kol(query, txtName.Text);
                    if (kol > 0)
                    {
                        MessageBox.Show("Такая должность в списке уже есть!");
                        txtName.Focus();
                        return;
                    }
                    var sqlCmd = new SqlCommand("insert_into_posts", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@salary", salary);
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {
                    var sqlCmd = new SqlCommand("update_posts", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(selcells[0].Value));
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@salary", salary);
                    sqlCmd.ExecuteNonQuery();
                }
            }
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
            fillTheTable(dgvP, "DISPLAY_POSTS");
        }

        private void frmPostsAC_Load(object sender, EventArgs e)
        {
            if (selcells != null)
            {
                txtName.Text = selcells[1].Value.ToString();
                txtSalary.Text = selcells[2].Value.ToString();
                txtName.Focus();
            }
        }
    }
}
