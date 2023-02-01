using AccountOperations;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class DeleteAccount : UserControl
    {
        private readonly AccountManagement manage = new AccountManagement();

        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (Errors.BoxIsEmpty(nameBox.Text) is true || Errors.BoxIsEmpty(numberBox.Text) is true)
            {
                return;
            }
            else if (Errors.IsNumber(nameBox) is true)
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            #region DeleteAccount
            manage.DeleteAccount(nameBox.Text, numberBox.Text);
            succesMessage.Text = $"Account {numberBox.Text} was sucessfully deleted.";
            nameBox.Clear();
            numberBox.Clear();
            #endregion




        }
    }
}
