using AccountOperations;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeePortal.UIComponents.CreditCardUI
{
    public partial class CreateCreditCardTab : UserControl
    {
        private readonly CustomerDataQuerries data = new CustomerDataQuerries();
        private readonly AccountDataQuerries querries;

        private SqlConnection connection = null;

        public CreateCreditCardTab()
        {
            InitializeComponent();
        }

        private void createCreditCard_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(nameBox.Text) is true || Errors.BoxIsEmpty(IBANBox.Text) is true)
            {
                return;
            }

            else if (Errors.IsNumber(nameBox) is true || Errors.IsNumber(IBANBox) is false)
            {
                MessageBox.Show("Wrong Imput\nName Cannot Contain Numbers\nIBAN Code Cannot Contain Letters.");

                return;
            }

            connection = new SqlConnection(data.ConnectionString);

            var createCard = new SqlCommand(querries.CreateCardData(IBANBox.Text, nameBox.Text), connection);

            connection.Open();

            var adapter = new SqlDataAdapter { InsertCommand = createCard };

            adapter.InsertCommand.ExecuteNonQuery();

            connection.Close();

            succesMsg.Text = $"Credit Card Created Succesfully!!!!";

            IBANBox.Clear();
            nameBox.Clear();

        }
    }
}
