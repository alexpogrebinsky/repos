using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ParameterizedSP
{
    public partial class Form1 : Form
    {
        public object CustomerIdTextBox { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void GetTotalSalesButton_Click(object sender, EventArgs e)
        {
            TotalSalesLabel.Text = String.Format("Total Sales: {0}", GetTotalSales(CustomerIDTextBox.Text));
        }

        private double GetTotalSales(string customerId)
        {
            double totalSales =-1;
            try
            {
                // Change the connection string
                // to match with your system.
                string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=LAPTOP-T6POAVG0\SQLEXPRESS";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = connection.CreateCommand();

                command.CommandType =CommandType.StoredProcedure;
                command.CommandText = "GetCustomerSales";
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@TotalSales", null);

                command.Parameters["@TotalSales"].DbType = DbType.Currency;
                command.Parameters["@TotalSales"].Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                totalSales = Double.Parse(command.Parameters["@TotalSales"].Value.ToString());
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return totalSales;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
