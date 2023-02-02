using EmployeePortal.DataAccesLayer;
using EmployeePortal.src;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class DeleteCustomerTab : UserControl
    {
        private readonly ModifyData modifyData = new ModifyData();
        public DeleteCustomerTab()
        {
            InitializeComponent();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerName.Text))
            {
                return;
            }
            if (Imput.IsNumber(customerName))
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            
            customerDeleted.Text = $"{modifyData.DeleteCustomer(customerName.Text)}";

            customerName.Clear();


        }
    }
}
