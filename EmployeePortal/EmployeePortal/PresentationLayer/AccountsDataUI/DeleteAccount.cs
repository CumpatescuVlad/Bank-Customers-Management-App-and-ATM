using EmployeePortal.src;
using EmployeePortal.Modeles;
using EmployeePortal.DataAccesLayer;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class DeleteAccount : UserControl
    {
        private readonly ModifyData modify = new ModifyData();

        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(numberBox.Text))
            {
                return;
            }
            else if (Imput.IsNumber(nameBox))
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            var deleteModel = new DeleteAccountModel() 
            { 
                AccountOwnerName= nameBox.Text,
                AccountName= accountNameBox.Text,
                AccountIBAN= accountIBANBox.Text,
                AccountNumber = numberBox.Text,
                TypeOfAccount= typeOfAccount.Text,
            };

            #region DeleteAccount
            modify.DeleteAccount(deleteModel);
            succesMessage.Text = $"Account {numberBox.Text} was sucessfully deleted.";
            nameBox.Clear();
            numberBox.Clear();
            #endregion




        }
    }
}
