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
    public partial class frmEmployeesAC : Form
    {
        private SqlConnection myConnection, con2;
        private DataSet myDS = new DataSet();
        private DataGridView dgvP;
        private DataGridViewSelectedCellCollection selcells = null;
        public frmEmployeesAC(SqlConnection con, string fun, DataGridView d, DataGridViewSelectedCellCollection _selcells)
        {
            InitializeComponent();
            myConnection = con;
            selcells = _selcells;
            con2 = con;
            dgvP = d;
            fillPostsBox();
            switch (fun)
            {
                case "add":
                    this.Text = "Добавить сотрудника";
                    break;
                case "change":
                    this.Text = "Изменить данные о сотруднике";
                    break;
            }
        }

        private void fillPostsBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Post_name from posts where post_name != 'Директор' Order by post_name", myConnection);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            cbPost.DataSource = tbl;
            cbPost.DisplayMember = "post_name";
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (myConnection)
            {
                if (this.Text == "Добавить сотрудника")
                {
                    var sqlCmd = new SqlCommand("insert_into_employee", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@secondname", txtSecondname.Text);
                    sqlCmd.Parameters.AddWithValue("@postName", cbPost.Text);
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {
                    var sqlCmd = new SqlCommand("update_employee", myConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(selcells[0].Value));
                    sqlCmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@secondname", txtSecondname.Text);
                    sqlCmd.Parameters.AddWithValue("@postName", cbPost.Text);
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
            fillTheTable(dgvP, "DISPLAY_EMPLOYEES");
        }

        private void frmEmployeesAC_Load(object sender, EventArgs e)
        {
            if (selcells != null)
            {
                txtSurname.Text = selcells[1].Value.ToString();
                txtName.Text = selcells[2].Value.ToString();
                txtSecondname.Text = selcells[3].Value.ToString();
                cbPost.Text = selcells[4].Value.ToString();
                txtSurname.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmEmployeesAC_Load_1(object sender, EventArgs e)
        {
            if (selcells != null)
            {
                txtSurname.Text = selcells[1].Value.ToString();
                txtName.Text = selcells[2].Value.ToString();
                txtSecondname.Text = selcells[3].Value.ToString();
                cbPost.Text = selcells[4].Value.ToString();
                txtSurname.Focus();
            }
        }

    }
}
