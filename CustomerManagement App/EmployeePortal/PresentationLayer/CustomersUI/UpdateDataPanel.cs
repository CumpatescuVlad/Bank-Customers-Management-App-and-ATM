using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class UpdateDataPanel : UserControl
    {
        private readonly CustomerDataManagement data = new CustomerDataManagement();

        public UpdateDataPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uppdateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(nameUpdBox.Text) is true)
            {
                return;

            }
            if (Errors.IsNumber(nameUpdBox) is true)
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            #region UpdateCustomerName
            Temp.CreateFile("NewCustomerFullName.txt", nameUpdBox.Text);
            data.UpdateCustomer("CustomerFullName", Temp.ReadFile("NewCustomerFullName.txt"), Temp.ReadFile("OldCustomerFullName.txt"));
            Temp.DisposeFile("OldCustomerFullName.txt");
            succesNameUpd.Text = "Customer Name Succesfully Changed";
            nameUpdBox.Clear();
            #endregion


        }

        private void uppdateEmailBtn_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(emailUpdBox.Text) is true)
            {
                return;

            }
            #region UpdateEmail
            data.UpdateCustomer("CustomerEmail", emailUpdBox.Text, Temp.ReadFile("NewCustomerFullName.txt"));
            succesUpdMail.Text = "Customer Email Succesfully Changed";
            emailUpdBox.Clear();

            #endregion

        }

        private void uppdatePhoneNum_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(phoneNumUpdBox.Text) is true)
            {
                return;

            }
            if (Errors.IsNumber(phoneNumUpdBox) is false)
            {
                MessageBox.Show("Phone Number Cannot Contain Letters.");

                return;
            }
            #region UpdatePhoneNumber
            data.UpdateCustomer("CustomerPhoneNumber", phoneNumUpdBox.Text, Temp.ReadFile("NewCustomerFullName.txt"));
            succesUpdPhone.Text = "Customer Phone Number Sucesfully Changed";
            phoneNumUpdBox.Clear();
            #endregion


        }
    }
}
