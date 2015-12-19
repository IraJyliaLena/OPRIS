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
using System.IO;

namespace PetShop
{
    public partial class frmPets : Form
    {
        private string path = "";
        private SqlConnection myConnection;
        private List<int> breed_ids = new List<int>();
        private DataGridView dgvP;
        private DataGridViewSelectedCellCollection selcells = null;
        public frmPets(SqlConnection conn, string fun, DataGridView dgv, DataGridViewSelectedCellCollection _selcells)
        {
            InitializeComponent();
            myConnection = conn;
            selcells = _selcells;
            dgvP = dgv;
            fillCombo(cbSpecies, "GET_SPECIES_LIST");//Species
            switch (fun)
            {
                case "add":
                    this.Text = "Добавить животное";
                    btnAddMore.Visible = true;
                    break;
                case "change":
                    this.Text = "Изменить данные о животном";
                    cbSpecies.Text = selcells[6].Value.ToString();
                    pictureBox1.Image = ByteArrayToImage((byte[])selcells[8].Value);
                    break;
            }
        }

        public Image ByteArrayToImage(byte[] inputArray)
        {
            var memoryStream = new MemoryStream(inputArray);
            return Image.FromStream(memoryStream);
        }

        private void fillDoubleCombo(ComboBox cmb, string commandText)
        {
            cbBreed.Items.Clear();
            breed_ids.Clear();
            SqlCommand myCommand = new SqlCommand(commandText, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter species = new SqlParameter("@species", SqlDbType.NVarChar, 50);
            species.Value = cbSpecies.Text;
            myCommand.Parameters.Add(species);
            try
            {
                SqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    breed_ids.Add(dataReader.GetInt32(0));
                    cmb.Items.Add(dataReader.GetString(1) + " (" + dataReader.GetString(2) + ")");
                }
                dataReader.Close();
                cmb.SelectedIndex = 0;
            }
            catch
            { MessageBox.Show("Породы данного вида\nотсутствуют в базе данных.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void fillCombo(ComboBox cmb, string commandText)
        {
            SqlCommand myCommand = new SqlCommand(commandText, myConnection);
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
                cmb.Items.Add(dataReader.GetString(0));
            dataReader.Close();
            cmb.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void errorMessage(TextBox txt, string errText)
        {
            MessageBox.Show(errText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txt.Select(0, txt.TextLength);
            txt.Focus();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            int res = 0;
            bool chk = int.TryParse(txtPrice.Text, out res);
            if (!chk || res <= 0)
                errorMessage(txtPrice, "Введите целое число больше 0!");
        }

        private bool add_pet()
        {
            bool done = false;
            if (txtPetName.Text.Length > 0)
                if (txtPrice.Text.Length > 0)
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
                    using (myConnection)
                    {
                        if (this.Text == "Добавить животное")
                        {
                            var sqlCmd = new SqlCommand("insert_into_pets", myConnection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@name", txtPetName.Text);
                            if (rbMale.Checked)
                                sqlCmd.Parameters.AddWithValue("@sex", "м");
                            else
                                sqlCmd.Parameters.AddWithValue("@sex", "ж");
                            sqlCmd.Parameters.AddWithValue("@birthday", Convert.ToDateTime(dtBirthday.Value.ToString().Substring(0, 10)));
                            sqlCmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                            sqlCmd.Parameters.AddWithValue("@breedID", breed_ids[cbBreed.SelectedIndex]);
                            System.IO.MemoryStream memoryStr = new System.IO.MemoryStream();
                            pictureBox1.Image.Save(memoryStr, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] b = memoryStr.ToArray();
                            sqlCmd.Parameters.AddWithValue("@im", b);
                            sqlCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            var sqlCmd = new SqlCommand("update_pet", myConnection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(selcells[0].Value));
                            sqlCmd.Parameters.AddWithValue("@name", txtPetName.Text);
                            if (rbMale.Checked)
                                sqlCmd.Parameters.AddWithValue("@sex", "м");
                            else
                                sqlCmd.Parameters.AddWithValue("@sex", "ж");
                            sqlCmd.Parameters.AddWithValue("@birthday", Convert.ToDateTime(dtBirthday.Value.ToString().Substring(0, 10)));
                            sqlCmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                            sqlCmd.Parameters.AddWithValue("@breedID", breed_ids[cbBreed.SelectedIndex]);
                            System.IO.MemoryStream memoryStr = new System.IO.MemoryStream();
                            pictureBox1.Image.Save(memoryStr, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] b = memoryStr.ToArray();
                            sqlCmd.Parameters.AddWithValue("@im", b);
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    done = true;
                }
                else
                    errorMessage(txtPrice, "Введите цену!");
            else
                errorMessage(txtPetName, "Введите кличку животного!");
            return done;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Фото питомца не выбрано!");
                return;
            }
            if (add_pet())
            {
                this.Hide();
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
                fillTheTable(dgvP, "DISPLAY_UNSOLD_PETS");
            }
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

        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDoubleCombo(cbBreed, "GET_BREED_LIST");//Breed
        }

        private void frmPets_Load(object sender, EventArgs e)
        {
            if (selcells != null)
            {
                txtPetName.Text = selcells[1].Value.ToString();
                rbFemale.Checked = selcells[2].Value.ToString().Trim() == "ж";
                txtPrice.Text = selcells[4].Value.ToString();
                cbBreed.Text = selcells[5].Value.ToString() + " (" + selcells[7].Value.ToString() + ")";
                dtBirthday.Text = selcells[3].Value.ToString().Remove(selcells[3].Value.ToString().IndexOf(" "));
                cbSpecies.Focus();
            }
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            add_pet();
            cbSpecies.SelectedIndex = 0;
            cbSpecies.Focus();
            dtBirthday.Value = DateTime.Now; 
            txtPrice.Text = "";
            txtPetName.Text = "";
            rbMale.Checked = true; 
        }

        private void btnAddBreed_Click(object sender, EventArgs e)
        {
            frmBreedsACD fbr = new frmBreedsACD(myConnection, "add", dgvP, null);
            fbr.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap myIm;
            OpenFileDialog imd = new OpenFileDialog();
            imd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            imd.InitialDirectory = "C:\\Users\\Ирина\\Desktop";
            imd.RestoreDirectory = true;
            if (imd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = imd.FileName;
                    myIm = new Bitmap(path);
                    pictureBox1.Image = (Image)myIm;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

    }
}
