using EmployeePortal.DataAccesLayer;
using EmployeePortal.src;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class ManageCustomerData : UserControl
    {
        private readonly ReadData readData = new ReadData();

        public ManageCustomerData()
        {
            InitializeComponent();
            updateDataPanel1.Hide();
            button2.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            updateDataPanel1.Show();
            updateDataPanel1.BringToFront();
            richTextBox1.Clear();
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fullNamebox.Text))
            {
                return;
            }
            else if (Imput.IsNumber(fullNamebox))
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            var customerData = readData.ReadCustomer(fullNamebox.Text);

            richTextBox1.Text = $"{customerData.CustomerName}----{customerData.CustomerPhoneNumber}----{customerData.CustomerPassword}";

            if (customerData is null)
            {
                richTextBox1.Text = "Customer Not Found.";
                fullNamebox.Clear();

                return;
            }

            fullNamebox.Clear();

            button2.Show();


        }
        
    }
}
