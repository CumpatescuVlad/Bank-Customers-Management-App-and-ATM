using System;
using System.Windows.Forms;

namespace EmployeeInterface
{
    public partial class EmployeeInterface : Form
    {
        Cache cache = new Cache();
        public EmployeeInterface()
        {
            InitializeComponent();
            addCustomer1.Hide();
            searchCustomer1.Hide();
            updateCustomerData1.Hide();
            deleteCustomer1.Hide();
            deleteCustomer2.Hide();
            EmployeeName.Text = $"Logged in as {cache.ReadFile("EmployeeName.txt")}";
            time.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
        }

        private void EmployeeName_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomer1.Show();
            addCustomer1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchCustomer1.Show();
            searchCustomer1.BringToFront();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            searchCustomer1.Hide();
            addCustomer1.Hide();
            updateCustomerData1.Hide();
            deleteCustomer1.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateCustomerData1.Show();
            updateCustomerData1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteCustomer1.Show();
            deleteCustomer1.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            cache.DisposeFile("OldCustomerFullName.txt");
            cache.DisposeFile("NewCustomerFullName.txt");
            //Folder Should be Disposed
            Environment.Exit(0);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timeStamp_Click(object sender, EventArgs e)
        {

        }
    }
}
