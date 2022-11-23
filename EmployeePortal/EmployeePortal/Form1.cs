using EmployeeInterface;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addCustomerTab1.Hide();
            manageCustomerData1.Hide();
            deleteCustomerTab1.Hide();
            manageAccountsTab1.Hide();
            createCreditCardTab1.Hide();
            addCompanyTab1.Hide();
            employeename.Text = $"Logged in as {Environment.UserName}";
            time.Text = $"Time: {DateTime.Now.Hour}:{DateTime.Now.Minute}";
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            addCustomerTab1.Show();
            addCustomerTab1.BringToFront();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            addCustomerTab1.Hide();
            deleteCustomerTab1.Hide();
            manageCustomerData1.Hide();
            manageAccountsTab1.Hide();
            createCreditCardTab1.Hide();
            addCompanyTab1.Hide();


        }
        private void manageCustomerDataBtn_Click(object sender, EventArgs e)
        {
            manageCustomerData1.Show();
            manageCustomerData1.BringToFront();

        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            deleteCustomerTab1.Show();
            deleteCustomerTab1.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Temp.DisposeFile("OldCustomerFullName.txt");
            Temp.DisposeFile("NewCustomerFullName.txt");
            Temp.DisposeFile("AccountIBAN.txt");
            Temp.DisposeFile("AccountName.txt");
            Temp.DisposeFile("AccountNumber.txt");
            Temp.DisposeFile("CustomerFullName.txt");
            Temp.DisposeFile("Total.txt");
            Temp.DisposeFile("TransactionsOrderedByAmount Desc.txt");
            Temp.DisposeFile("TransactionsOrderedByDate Asc.txt");
            Temp.DisposeFile("EmployeeID.txt");
            Temp.DisposeFile("EmployeePassword.txt");

            Environment.Exit(0);

        }

        private void manageAccountsBtn_Click(object sender, EventArgs e)
        {
            manageAccountsTab1.Show();
            manageAccountsTab1.BringToFront();

        }

        private void createCreditCardBtn_Click(object sender, EventArgs e)
        {
            createCreditCardTab1.Show();
            createCreditCardTab1.BringToFront();

        }

        private void addACompanyBtn_Click(object sender, EventArgs e)
        {
            addCompanyTab1.Show();
            addCompanyTab1.BringToFront();
        }


    }
}
