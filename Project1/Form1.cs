using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged
(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        static void Main(string[] args)
        {
            
        }
    }
}
