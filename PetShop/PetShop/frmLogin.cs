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
    public partial class frmLogin : Form
    {
        private SqlConnection myConnection;
        public const string sql_constString = @"Data Source=.;Initial Catalog=PetShopO;";
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.TextLength == 0)
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
            }
            else
                if (txtPassword.TextLength == 0)
                {
                    MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }
                else
                {
                    string connectionString = "user id=" + txtUserName.Text + "; password=" + txtPassword.Text + ";";
                    myConnection = new SqlConnection(sql_constString+connectionString);
                    try
                    {
                        myConnection.Open();
                        frmMain main = new frmMain(myConnection);
                        this.Hide();
                        main.Show(this);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        //MessageBox.Show("Неверное имя пользователя\nили пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPassword.Select(0, txtPassword.TextLength);
                        txtPassword.Focus();
                    }
                }
        }

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Select(0, txtUserName.TextLength);
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
