using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class frmStatistics : Form
    {
        private SqlConnection myConnection;
        private DateTime openDate = new DateTime(2014, 05, 01);

        public frmStatistics(SqlConnection con)
        {
            InitializeComponent();
            myConnection = con;
            dtFirstDate.Value = openDate;
            dtSecondDate.Value = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
            fillTheTable();
        }

        private void fillTheTable()
        {
            SqlCommand myCommand =new SqlCommand("DISPLAY_SOME_SOLD_PETS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter d1 = new SqlParameter("@date1", SqlDbType.NVarChar, 50);
            d1.Value = dtFirstDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d1);

            SqlParameter d2 = new SqlParameter("@date2", SqlDbType.NVarChar, 50);
            d2.Value = dtSecondDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            da.Fill(dt);
           
            dgvStats.DataSource = dt;

            lblProfit.Text = "Прибыль от продажи: " + getProfit() + " руб.";
        }

        private string getProfit()
        {
            SqlCommand myCommand = new SqlCommand("GET_PROFIT", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter d1 = new SqlParameter("@date1", SqlDbType.NVarChar, 50);
            d1.Value = dtFirstDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d1);

            SqlParameter d2 = new SqlParameter("@date2", SqlDbType.NVarChar, 50);
            d2.Value = dtSecondDate.Value.ToString().Substring(0, 10);
            myCommand.Parameters.Add(d2);

            SqlParameter profit = new SqlParameter("@profit", SqlDbType.Int, 10);
            profit.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(profit);

            myCommand.ExecuteNonQuery();

            return profit.Value.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            fillTheTable();
        }

        private void frmStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            myConnection.Close();
            this.Owner.Show();
        }
    }
}
