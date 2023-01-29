using DataValidation;
using EmployeeInterface;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class DeleteCustomerTab : UserControl
    {
        private readonly CustomerDataManagement data = new CustomerDataManagement();
        public DeleteCustomerTab()
        {
            InitializeComponent();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(customerName.Text) is true)
            {
                return;
            }
            if (Errors.IsNumber(customerName) is true)
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            #region DeleteCustomer
            data.DeleteCustomer(customerName.Text);
            customerDeleted.Text = "Customer Sucessfully deleted";
            customerName.Clear();
            #endregion


        }
    }
}
