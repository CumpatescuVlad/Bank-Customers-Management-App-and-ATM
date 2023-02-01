using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class ManageCustomerData : UserControl
    {
        private readonly CustomerDataQuerries data = new CustomerDataQuerries();

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
            if (Errors.BoxIsEmpty(fullNamebox.Text) is true)
            {
                return;
            }
            if (Errors.IsNumber(fullNamebox) is true)
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            DisplayCustomer(fullNamebox.Text);

            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "Customer Not Found.";
                fullNamebox.Clear();
                return;
            }

            Temp.CreateFile("NewCustomerFullName.txt", fullNamebox.Text);

            fullNamebox.Clear();

            button2.Show();


        }
        public void DisplayCustomer(string customerName)
        {
            var searchConnection = new SqlConnection(data.ConnectionString);

            var displayCustomerCommand = new SqlCommand($"{data.ReadCustomerDataString(customerName)}", searchConnection);

            searchConnection.Open();

            var readCustomer = displayCustomerCommand.ExecuteReader();

            while (readCustomer.Read())
            {
                richTextBox1.Text =
                 $"{readCustomer.GetValue(0)}\t{readCustomer.GetValue(1)}\t{readCustomer.GetValue(2)}\t\t{readCustomer.GetValue(3)}";

                Temp.CreateFile("OldCustomerFullName.txt", $"{readCustomer.GetValue(0)}");
            }

            searchConnection.Close();

        }
    }
}
