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
    public partial class frmAddSpec : Form
    {
        public string value = "";
        public frmAddSpec(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        public frmAddSpec(string title, string name)
        {
            InitializeComponent();
            this.Text = title;
            tbValue.Text = name;
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
