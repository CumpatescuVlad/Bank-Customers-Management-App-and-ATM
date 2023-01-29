using AccountOperations;
using DataValidation;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class DisplayAccounts : UserControl
    {
        private readonly AccountManagement manage = new AccountManagement();
        public DisplayAccounts()
        {
            InitializeComponent();

        }

        private void searchCustomersAccount_Click(object sender, EventArgs e)
        {

            if (Errors.BoxIsEmpty(customerNameBox.Text) is true)
            {
                return;
            }

            richTextBox1.Text = manage.DisplayAccounts(customerNameBox.Text);

            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "Customer Not Found.";
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
