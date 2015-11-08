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
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace PetShop
{
    public partial class frmMain : Form
    {
        private SqlConnection myConnection;
        public frmMain(SqlConnection con, String user_name, String user_role)
        {
            InitializeComponent();
            myConnection = con;
            this.Text += " (" + user_name + ")";
            getPrivileges(user_role);
            fillTheTable(dgvPets, "DISPLAY_PETS");
        }

        /// <summary>
        /// Отобразить содержимое MainForm в соответствии с ролью
        /// </summary>
        /// <param name="role"></param>
        private void getPrivileges(String role)
        {
            switch (role)
            {
                case "директор":
                    break;
                case "СОП":
                    break;
                case "продавец":
                    break;
                default:
                    break;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            myConnection.Close();
            this.Owner.Show();
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
                MessageBox.Show(ex.Message); ;
            }
            SqlCommand comm = new SqlCommand(commandText, myConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv.DataSource = bs;
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    fillTheTable(dgvPets, "DISPLAY_PETS");
                    break;
                case 1:
                    fillTheTable(dgvProvider, "DISPLAY_PROVIDER_PUB");
                    break;
                case 2:
                    fillTheTable(dgvEmployee, "DISPLAY_EMPLOYEES_PUB");
                    break;
                default:
                    break;
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }

        private void выйтиИзПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            myConnection.Close();
            myConnection.Dispose();
            this.Owner.Show();
        }

        private void поставщикиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProviders prov = new frmProviders(myConnection, dgvProvider);
            this.Hide();
            prov.Show(this);
        }

        private void подобратьЖивотноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelect sel = new frmSelect(myConnection);
            this.Hide();
            sel.Show(this);
        }
    }
}
