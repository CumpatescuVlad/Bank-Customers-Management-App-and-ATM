using EmployeeInterface;
using EmployeePortal.DataAccesLayer;
using EmployeePortal.Modeles;
using EmployeePortal.src;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class AddCustomerTab : UserControl
    {
        private readonly ModifyData modifyData= new ModifyData();
        
        public AddCustomerTab()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text)|| String.IsNullOrEmpty(emailBox.Text)|| String.IsNullOrEmpty(phoneNumBox.Text))
            {
                return;
            }

            else if (Imput.IsNumber(nameBox)|| Imput.IsNumber(phoneNumBox) is false)
            {
                MessageBox.Show("Wrong Imput\nName Cannot Contain Numbers\nPhone Number Cannot Contain Letters.");

                return;
            }

            var customerModel = new CustomerModel() 
            {
                CustomerName= nameBox.Text,
                CustomerEmail= emailBox.Text,
                CustomerPhoneNumber= phoneNumBox.Text,
            };
            
            succesName.Text = $"{modifyData.AddCustomer(customerModel)}";

            if (String.IsNullOrEmpty(succesName.Text))
            {
                succesName.Text = "Error";
            }

            nameBox.Clear();
            emailBox.Clear();
            phoneNumBox.Clear();
            

        }

       
    }
}
