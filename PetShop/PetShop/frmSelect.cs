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
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        BindingSource bindingSource;
        DataTable table;
        string select = "";
        string selectBase = "select distinct pet_id as '№', pet_name as 'Кличка', pet_sex as 'Пол', pet_birthday as 'Дата рождения', breed_name as 'Порода', species_name as 'Вид', provider_name as 'Поставщик', pet_price as 'Цена' from Pets, Breeds, Species, Providers where Breeds.breed_id = Pets.breed_id and Species.species_id = Breeds.species_id and Providers.provider_id = Breeds.provider_id and";
        string selectBaseZapas = "select pet_id as '№', pet_name as 'Кличка', pet_sex as 'Пол', pet_birthday as 'Дата рождения', breed_name as 'Порода', species_name as 'Вид', provider_name as 'Поставщик', pet_price as 'Цена' from Pets, Breeds, Species, Providers where Breeds.breed_id = Pets.breed_id and Species.species_id = Breeds.species_id and Providers.provider_id = Breeds.provider_id and";
        string type = "";
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
                    selectBase = selectBase + " Pets.pet_sex";
                    type = "string";
                    break;
                case "Порода":
                    selectBase = selectBase + " Breeds.breed_name";
                    type = "string";
                    break;
                case "Вид":
                    selectBase = selectBase + " Species.species_name";
                    type = "string";
                    break;
                case "Дата рождения":
                    selectBase = selectBase + " Pets.pet_birthday";
                    type = "string";
                    break;
                case "Цена":
                    selectBase = selectBase + " Pets.pet_price";
                    type = "int";
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
            select = select + " " + lbFilds.Text;
            rtbSelect.Text = select;
            translateField(lbFilds.Text);
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            select = select + " =";
            selectBase = selectBase + " =";
            rtbSelect.Text = select;
        }

        private void btOr_Click(object sender, EventArgs e)
        {
            select = select + " OR";
            selectBase = selectBase + " OR";
            rtbSelect.Text = select;
        }

        private void btMore_Click(object sender, EventArgs e)
        {
            select = select + " >";
            selectBase = selectBase + " >";
            rtbSelect.Text = select;
        }

        private void btAnd_Click(object sender, EventArgs e)
        {
            select = select + " AND";
            selectBase = selectBase + " AND";
            rtbSelect.Text = select;
        }

        private void btLess_Click(object sender, EventArgs e)
        {
            select = select + " <";
            selectBase = selectBase + " <";
            rtbSelect.Text = select;
        }

        private void btNot_Click(object sender, EventArgs e)
        {
            select = select + " NOT";
            selectBase = selectBase + " NOT";
            rtbSelect.Text = select;
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnAddZnach_Click(object sender, EventArgs e)
        {
            if (type == "string")
                selectBase = selectBase + " '" + tbZnach.Text.ToString() + "'";
            else selectBase = selectBase + " " + Convert.ToInt32(tbZnach.Text);
            select = select + " " + tbZnach.Text.ToString();
            rtbSelect.Text = select;
            tbZnach.Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            select = "";
            rtbSelect.Text = "";
            selectBase = selectBaseZapas;
        }

        private void GetData ()
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectBase, myConnection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в запросе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void moreEqual_Click(object sender, EventArgs e)
        {
            select = select + " >=";
            selectBase = selectBase + " >=";
            rtbSelect.Text = select;
        }

        private void lessEqual_Click(object sender, EventArgs e)
        {
            select = select + " <=";
            selectBase = selectBase + " <=";
            rtbSelect.Text = select;
        }

        private void butCansel_Click(object sender, EventArgs e)
        {
            int lengthStr = selectBase.Length;
            int posProb = selectBase.LastIndexOf(' ');
            int k = lengthStr - posProb;
            selectBase = selectBase.Remove(posProb, k);
            lengthStr = select.Length;
            posProb = select.LastIndexOf(' ');
            k = lengthStr - posProb;
            select = select.Remove(posProb, k);
            rtbSelect.Text = select;
        }

        private void lbFilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = select + " " + lbFilds.Text;
            rtbSelect.Text = select;
            translateField(lbFilds.Text);
        }
    }
}
