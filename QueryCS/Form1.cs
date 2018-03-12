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

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(
object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
              
                SelectData(textBox1.Text);
            }
        }

        private void SelectData(string selectCommandText)
        {
            try
            {
                // Change the connection string
                // to match with your system.
                string selectConnection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=LAPTOP-T6POAVG0\SQLEXPRESS";
                SqlDataAdapter dataAdapter =
                new SqlDataAdapter(
                selectCommandText, selectConnection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
