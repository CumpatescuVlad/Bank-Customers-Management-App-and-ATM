using EmployeeInterface;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class AddCustomerTab : UserControl
    {
        private readonly GenerateSecurityElements element = new GenerateSecurityElements();
        private readonly CustomerDataQuerries data = new CustomerDataQuerries();
        private SqlConnection insertConnection = null;
        public AddCustomerTab()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(nameBox.Text) is true || Errors.BoxIsEmpty(emailBox.Text) is true || Errors.BoxIsEmpty(phoneNumBox.Text) is true)
            {
                return;
            }

            if (Errors.IsNumber(nameBox) is true || Errors.IsNumber(phoneNumBox) is false)
            {
                MessageBox.Show("Wrong Imput\nName Cannot Contain Numbers\nPhone Number Cannot Contain Letters.");

                return;
            }
            #region AddCustomer
            InsertCustomerData();
            succesName.Text = "Customer Sucessfully Added";
            nameBox.Clear();
            emailBox.Clear();
            phoneNumBox.Clear();
            #endregion

        }

        private void InsertCustomerData()
        {
            string insertCustomerString = $@"Insert into Customers (CustomerFullName,CustomerPassword,CustomerEmail,
             CustomerPhoneNumber,FirstInstall,CustomerAppPin) values
             ('{nameBox.Text}','{element.GeneratePassword()}','{emailBox.Text}','{phoneNumBox.Text}','1',{element.GenerateAppPIN()})";


            insertConnection = new SqlConnection(data.ConnectionString);

            insertConnection.Open();

            var insertCommand = new SqlCommand(insertCustomerString, insertConnection);

            var adapter = new SqlDataAdapter { InsertCommand = insertCommand };

            adapter.InsertCommand.ExecuteNonQuery();

            insertConnection.Close();

        }
    }
}
