using EmployeePortal.DataAccesLayer;
using EmployeePortal.Modeles;
using EmployeePortal.src;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class CreateAccountTab : UserControl
    {
        private readonly ModifyData modifyData = new ModifyData();
        public CreateAccountTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool emptyImput = String.IsNullOrEmpty(customerNameBox.Text) || String.IsNullOrEmpty(accountNameBox.Text) || String.IsNullOrEmpty(accountInitialAmountBox.Text)
                ||String.IsNullOrEmpty(accountIBANBox.Text)||String.IsNullOrEmpty(accountNumberBox.Text)||String.IsNullOrEmpty(typeOfAccountBox.Text);

            if (emptyImput)
            {
                return;
            }
            else if (Imput.IsNumber(customerNameBox)|| Imput.IsNumber(accountNameBox)||Imput.IsNumber(accountInitialAmountBox) is false)
            {
                MessageBox.Show("Wrong Imput \nAccounts Amount Cannot Contain Letters\nNames cannot Contain Numbers.");

                return;
            }
            var accountModel = new CreateAccountModel()
            {
                AccountOwnerName = customerNameBox.Text,
                AccountNumber= accountNumberBox.Text,
                TypeOfAccount = typeOfAccountBox.Text,
                AccountName= accountNameBox.Text,
                AccountIBAN = accountIBANBox.Text,
                Ballance =int.Parse(accountInitialAmountBox.Text),
                
            };

            modifyData.CreateBankAccount(accountModel);
            accountCreatedLbl.Text = $"Account {accountNameBox.Text} was succesfully created";
            customerNameBox.Clear();
            accountInitialAmountBox.Clear();
            accountNameBox.Clear();
            accountNumberBox.Clear();
            accountNameBox.Clear();
            accountIBANBox.Clear();
            typeOfAccountBox.Clear();

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
