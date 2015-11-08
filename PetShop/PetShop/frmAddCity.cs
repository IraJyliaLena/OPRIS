using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmAddCity : Form
    {
        public string value = "";
        public frmAddCity(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void frmAddCity_Load(object sender, EventArgs e)
        {

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            value = tbValue.Text;
            this.Close();
        }

        private void butCansel_Click(object sender, EventArgs e)
        {
            value = "";
            this.Close();
        }
    }
}
