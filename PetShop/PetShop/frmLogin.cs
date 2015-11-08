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
        public const string sql_constString = @"Data Source=.; Initial Catalog=PetShopO; user id = sa; password=1";
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
                    myConnection = new SqlConnection(sql_constString);
                    try
                    {
                        myConnection.Open();
                        
                        String role = get_user_info();

                        if (role != null)
                        {
                            frmMain main = new frmMain(myConnection, txtUserName.Text, role);
                            this.Hide();
                            main.Show(this);
                        }
                        else
                        {
                            MessageBox.Show("Неверное имя пользователя\nили пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPassword.Select(0, txtPassword.TextLength);
                            txtPassword.Focus();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private String get_user_info()
        {
            string commandText = "INIT_USER";
            SqlCommand myCommand = new SqlCommand(commandText, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter n = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            n.Value = txtUserName.Text;
            myCommand.Parameters.Add(n);
            String role = null;
            try
            {
                SqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    String pass = reader.GetString(1);
                    if (pass == txtPassword.Text)
                        role = reader.GetString(2);
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Запрос не выполнен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return role;
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
