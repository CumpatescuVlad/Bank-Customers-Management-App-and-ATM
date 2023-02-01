using AccountOperations;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class CreateAccountTab : UserControl
    {
        private readonly AccountManagement manage = new AccountManagement();
        public CreateAccountTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(customerNameBox.Text) is true || Errors.BoxIsEmpty(accountNameBox.Text) is true || Errors.BoxIsEmpty(accountInitialAmountBox.Text) is true)
            {
                return;
            }
            else if (Errors.IsNumber(customerNameBox) is true || Errors.IsNumber(accountNameBox) is true || Errors.IsNumber(accountInitialAmountBox) is false)
            {
                MessageBox.Show("Wrong Imput \nAccounts Amount Cannot Contain Letters\nNames cannot Contain Numbers.");

                return;
            }


            #region CreateAccount
            manage.CreateAccount(customerNameBox.Text, accountNameBox.Text, int.Parse(accountInitialAmountBox.Text));
            accountCreatedLbl.Text = $"Account {accountNameBox.Text} was succesfully created";
            customerNameBox.Clear();
            accountInitialAmountBox.Clear();
            accountNameBox.Clear();
            #endregion


        }
        #region TextBoxes
        private void customerNameBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void accountNameBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void accountInitialAmountBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void CreateAccountTab_Load(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
