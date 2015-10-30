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
    public partial class frmSelect : Form
    {
        string select = "";
        string selectBase = "";
        private SqlConnection myConnection;
        public frmSelect(SqlConnection con)
        {
            InitializeComponent();
            myConnection = con;
        }

        private void translateField(string txt)
        {
            switch(txt)
            {
                case "Пол":
                    select = select + " pet_sex";
                    break;
                case "Порода":
                    select = select + " breed_name";
                    break;
                case "Вид":
                    select = select + " species_name";
                    break;
                case "Дата рождения":
                    select = select + " pet_birthday";
                    break;
                case "Цена":
                    select = select + " pet_price";
                    break;
            }
        }

        private void frmSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void btAddField_Click(object sender, EventArgs e)
        {
            select = select + lbFilds.Text;
            rtbSelect.Text = select;
            translateField(lbFilds.Text);
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            select = select + " = ";
            rtbSelect.Text = select;
        }

        private void btOr_Click(object sender, EventArgs e)
        {
            select = select + " OR ";
            rtbSelect.Text = select;
        }

        private void btMore_Click(object sender, EventArgs e)
        {
            select = select + " > ";
            rtbSelect.Text = select;
        }

        private void btAnd_Click(object sender, EventArgs e)
        {
            select = select + " AND ";
            rtbSelect.Text = select;
        }

        private void btLess_Click(object sender, EventArgs e)
        {
            select = select + " < ";
            rtbSelect.Text = select;
        }

        private void btNot_Click(object sender, EventArgs e)
        {
            select = select + " NOT ";
            rtbSelect.Text = select;
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnAddZnach_Click(object sender, EventArgs e)
        {
            string znach = tbZnach.Text.ToString();
            select = select + " " + znach + " ";
            rtbSelect.Text = select;
            tbZnach.Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            select = "";
            rtbSelect.Text = "";
        }
    }
}
