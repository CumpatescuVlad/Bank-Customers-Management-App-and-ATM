using AccountOperations;
using DataValidation;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class AddCompanyTab : UserControl
    {
        AccountManagement manage = new AccountManagement();
        public AddCompanyTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(companyName.Text) is true || Errors.BoxIsEmpty(companyService.Text) is true)
            {
                return;
            }
            if (Errors.IsNumber(companyName) is true || Errors.IsNumber(companyService) is true)
            {
                MessageBox.Show("Company Name Or Company service Cannot Contain Numbers.");

                return;
            }

            #region CreateCompany
            manage.CreateCompanyAccount(companyName.Text, companyService.Text);
            label2.Text = $"Company {companyName.Text} was succesfully added. ";
            label2.Show();
            companyName.Clear();
            companyService.Clear();
            #endregion

        }

        private void AddCompanyTab_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }
    }
}
