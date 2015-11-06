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
        private SqlConnection myConnection;
        private DataSet myDS = new DataSet();
        private DataGridView dgvP;
        public frmProvidersACD(SqlConnection con, string fun, DataGridView d)
        {
            InitializeComponent();
            myConnection = con;
            dgvP = d;
            SqlDataAdapter da = new SqlDataAdapter("select city_name from Cities Order by city_name", myConnection);
            DataTable tbl=new DataTable();
            da.Fill(tbl);
            cbCity.DataSource = tbl;
            cbCity.DisplayMember = "city_name";
            switch (fun)
            {
                case "add": 
                    this.Text = "Добавить поставщика";
                    break;
                case "change":
                    this.Text = "Изменить данные";
                    break;
            }
        }

        private void fillCityBox()
        {
            //string commandText = "GET_CITY_LIST";
            //DbCommand myCommand = DbLog.CreateCommand(commandText, myConnection);
            //DbDataReader reader = DbLog.ExecuteReader(myCommand);
            //while (reader.Read())
            //    cbCity.Items.Add(reader.GetString(0));
            //reader.Close();
            //cbCity.SelectedIndex = 0;
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
                var sqlCmd = new SqlCommand("insert_into_provider", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@nameProvider", txtName.Text);
                sqlCmd.Parameters.AddWithValue("@phone", Convert.ToInt32(txtPhone.Text));
                sqlCmd.Parameters.AddWithValue("@account", Convert.ToInt32(txtAccount.Text));
                sqlCmd.Parameters.AddWithValue("@cityName", cbCity.Text);
                sqlCmd.ExecuteNonQuery();
            }
            this.Hide();
            fillTheTable(dgvP, "DISPLAY_PROVIDER");
        }
    }
}
