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
        public frmProviders(SqlConnection con)
        {
            InitializeComponent();
            myConnection = con;
            fillTheTable(dgvProviders, "DISPLAY_PROVIDER");
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
            this.Owner.Show();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            frmProvidersACD prov1 = new frmProvidersACD(myConnection, "add", dgvProviders);
            prov1.Show(this); 
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            frmProvidersACD prov1 = new frmProvidersACD(myConnection, "change", dgvProviders);
            this.Hide();
            prov1.Show(this);
        }
    }
}
