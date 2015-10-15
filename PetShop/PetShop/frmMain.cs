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
    public partial class frmMain : Form
    {
        private SqlConnection myConnection;
        public frmMain(SqlConnection con)
        {
            InitializeComponent();
            myConnection = con;
            getPrivileges();
            fillTheTable(dgvPets, "DISPLAY_PETS");
        }

        private void getPrivileges()
        {
            string commandText = "GET_ROLE_NAME";
            SqlCommand myCommand = new SqlCommand(commandText, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@role", SqlDbType.NVarChar, 50);
            p.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(p);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch
            { p.Value = "sa"; }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            myConnection.Close();
            this.Owner.Show();
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
    }
}
