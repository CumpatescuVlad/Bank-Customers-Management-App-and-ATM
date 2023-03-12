namespace EmployeePortalWinforms.AccountsUI
{
    public partial class AccountsIndex : UserControl
    {
        public AccountsIndex()
        {
            InitializeComponent();
            homeBTN.Hide();
            searchAccount1.Hide();
            searchTransactions1.Hide();
            displayAccounts1.Hide();
            displayTransactions1.Hide();
            createAccount1.Hide();
            deleteAccount1.Hide();
        }

        private void searchAccounts_Click(object sender, EventArgs e)
        {
            searchAccount1.Show();
            searchAccount1.BringToFront();
            homeBTN.Show();
        }

        private void searchTransactions_Click(object sender, EventArgs e)
        {
            searchTransactions1.Show();
            searchTransactions1.BringToFront();
            homeBTN.Show();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            createAccount1.Show();
            createAccount1.BringToFront();
            homeBTN.Show();
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            deleteAccount1.Show();
            deleteAccount1.BringToFront();
            homeBTN.Show();
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            deleteAccount1.Hide();
            createAccount1.Hide();
            searchTransactions1.Hide();
            searchAccount1.Hide();
            homeBTN.Hide();
        }

        private void searchTransactions1_Load(object sender, EventArgs e)
        {

        }
    }
}
