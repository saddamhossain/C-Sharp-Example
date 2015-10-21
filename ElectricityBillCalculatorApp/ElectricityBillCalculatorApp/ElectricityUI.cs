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

namespace ElectricityBillCalculatorApp
{
    public partial class ElectricityUI : Form
    {
        private double belowOrEqual100 = 3.50;
        private double belowOrEqual200 = 4.50;
        private double belowOrEqual400 = 5.00;
        private double avove400 = 7.00;
        double totalUnitConsumed;
        public ElectricityUI()
        {
            InitializeComponent();
        }

        private void totalUnitConsumedButton_Click(object sender, EventArgs e)
        {
           

            string name = nameTextBox.Text;
            DateTime priviousMonth = dateTimePicker1.Value;
            DateTime currentMonth = dateTimePicker2.Value;

            double currentUnits = Convert.ToDouble(currentUnitTextBox.Text);
            double prevoiusUnits =Convert.ToDouble(previousUnitTextBox.Text);

            totalUnitConsumed = currentUnits - prevoiusUnits;

            totalUnitConsumedLabel.Text = totalUnitConsumed.ToString();

            // here total 

            if ((totalUnitConsumed <= 100) && (1 <= 100))
            {
                double result = belowOrEqual100 * totalUnitConsumed;
                totalBillPayableLabel.Text = result.ToString();
            }
            else if (totalUnitConsumed <= 200)
            {
                double result = belowOrEqual200 * totalUnitConsumed;
                totalBillPayableLabel.Text = result.ToString();
            }
            else if (totalUnitConsumed <= 400)
            {
                double result = belowOrEqual400 * totalUnitConsumed;
                totalBillPayableLabel.Text = result.ToString();
            }
            else if (totalUnitConsumed > 400)
            {
                double result = avove400 * totalUnitConsumed;
                totalBillPayableLabel.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid input.");
            }

            // database  

            string conn = @"server=SADDAMHOSSAIN\SQLEXPRESS; database=ElectricityDb; integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();

            string query = string.Format("INSERT INTO t_Electricity VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", name, priviousMonth, currentMonth, prevoiusUnits, currentUnits, totalUnitConsumed);

            SqlCommand command = new SqlCommand(query, connection);
            int affctedRow = command.ExecuteNonQuery();
            if (affctedRow > 0)
            {
                MessageBox.Show("Data insert successfully");
            }
            else
            {
                MessageBox.Show("Some problem");
            }



        }

      

        private void electricityChargesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Units consumed less than or equal to 100, rate per unit = 3.50 " + "\n" +
                "Units consumed less than or equal to 200, rate per unit = 4.50 " + "\n" +
                "Units consumed less than or equal to 400, rate per unit = 5.50 " + "\n" +
                "Units consumed avobe 400, rate per unit = 7.00 "
                );
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=SADDAMHOSSAIN\SQLEXPRESS; database=ElectricityDb; integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();

            string query = string.Format("SELECT * FROM t_Electricity");

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader aReader = command.ExecuteReader();

            List<Electric> students = new List<Electric>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Electric aElectric = new Electric();
                    aElectric.ElectricityId = (int)aReader[0];
                    
                    aElectric.PreviousMonth = (DateTime)aReader[1];
                    aElectric.CurrentMonth = (DateTime)aReader[2];
                    aElectric.PreviousUnits = (double)aReader[3];
                    aElectric.CurrentUnits = (double)aReader[4];
                    aElectric.TotalUnitConsumed = (double)aReader[5];           
                    students.Add(aElectric);
                }
            }
            connection.Close();
            detailsDataGridView.DataSource = students;

        }
    }
}
