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
        public frmMain(SqlConnection con, String user_name)
        {
            InitializeComponent();
            myConnection = con;
            this.Text += " (" + user_name + ")";
            getPrivileges(user_name);
            fillTheTable(dgvPets, "DISPLAY_PETS");
        }

        private void getPrivileges(String user)
        {
            string commandText = "GET_ROLE_NAME";
            SqlCommand myCommand = new SqlCommand(commandText, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter n = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            n.Value = user;
            myCommand.Parameters.Add(n);
            SqlParameter p = new SqlParameter("@role", SqlDbType.NVarChar, 50);
            p.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(p);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch
            { /*что-то тут надо написать*/ }
            switch (n.Value.ToString())
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

        private void новыйЗапросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSelect sel = new frmSelect(myConnection);
            this.Hide();
            sel.Show(this);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProviders prov = new frmProviders(myConnection);
            this.Hide();
            prov.Show(this);
        }
    }
}
