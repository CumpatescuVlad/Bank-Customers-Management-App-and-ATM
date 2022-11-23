using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class ManageAccountsTab : UserControl
    {
        public ManageAccountsTab()
        {
            InitializeComponent();
            displayAccounts1.Hide();
            createAccountTab3.Hide();
            transactionsLog1.Hide();
            backBTn.Hide();
            deleteAccount1.Hide();
        }

        private void displayAccountsBtn_Click(object sender, EventArgs e)
        {
            displayAccounts1.Show();
            displayAccounts1.BringToFront();
            displayAccountsBtn.Hide();
            createNewAccountBtn.Hide();
            transactionsLog1.Hide();
            deleteAccount1.Hide();
            button1.Hide();
            backBTn.Show();

        }

        private void ManageAccountsTab_Load(object sender, EventArgs e)
        {

        }

        private void createNewAccountBtn_Click(object sender, EventArgs e)
        {
            createAccountTab3.Show();
            createAccountTab3.BringToFront();
            displayAccountsBtn.Hide();
            createNewAccountBtn.Hide();
            deleteAccount1.Hide();
            button1.Hide();
            backBTn.Show();

        }

        private void backBTn_Click(object sender, EventArgs e)
        {
            displayAccounts1.Hide();
            createAccountTab3.Hide();
            transactionsLog1.Hide();
            backBTn.Hide();
            displayAccountsBtn.Show();
            createNewAccountBtn.Show();
            deleteAccount1.Show();
            deleteAccount1.Hide();
            button1.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            transactionsLog1.Show();
            transactionsLog1.BringToFront();
            displayAccountsBtn.Hide();
            createNewAccountBtn.Hide();
            button1.Hide();
            backBTn.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            deleteAccount1.Show();
            deleteAccount1.BringToFront();
            displayAccountsBtn.Hide();
            createNewAccountBtn.Hide();
            button1.Hide();
            backBTn.Show();


        }
    }
}
