using AccountOperations;
using EmployeePortal.DataAccesLayer;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class DisplayAccounts : UserControl
    {
        private readonly ReadData readData = new ReadData();
        public DisplayAccounts()
        {
            InitializeComponent();
            customerNameBox.GotFocus += CustomerNameBox_GotFocus;
            displayOwnerName.Hide();
            displayIBAN.Hide();
            displayAccountNumber.Hide();
            displayAccountBallance.Hide();
            displayAccountName.Hide();
            errorLabel.Hide();
        }

        private void CustomerNameBox_GotFocus(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        private void searchCustomersAccount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerNameBox.Text))
            {
                return;
            }

            var accounts = readData.ReadAccounts(customerNameBox.Text);

            displayOwnerName.Text += accounts.AccountOwnerName;
            displayIBAN.Text += accounts.AccountIBAN;
            displayAccountNumber.Text+= accounts.AccountNumber;
            displayAccountBallance.Text+= accounts.AccountBallance.ToString();
            displayAccountName.Text += accounts.AccountName;

            if (accounts is null)
            {
                errorLabel.Show();
                errorLabel.Text = "Customer Not Found.";
                customerNameBox.Clear();
            }

            customerNameBox.Clear();

        }
        #region TextBoxes
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNameBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
