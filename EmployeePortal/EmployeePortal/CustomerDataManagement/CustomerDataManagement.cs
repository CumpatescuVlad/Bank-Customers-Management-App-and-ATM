using AccountOperations;
using System.Data.SqlClient;

namespace EmployeeInterface
{
    public class CustomerDataManagement
    {
        private readonly CustomerDataQuerries data = new CustomerDataQuerries();
        private readonly AccountDataQuerries creditCard = new AccountDataQuerries();
        private SqlConnection connection = null;
        private SqlCommand command = null;
        
        private int _attempts = 3;

        public int Attempts { get => _attempts; set => _attempts = value; }

        public void UpdateCustomer(string columName, string value, string oldCustomerName)
        {
            connection = new SqlConnection(data.ConnectionString);

            connection.Open();

            command = new SqlCommand(data.UpdateCustomerString($"{columName}", $"{value}", $"{oldCustomerName}"), connection);

            var updateAdapter = new SqlDataAdapter { UpdateCommand = command };

            updateAdapter.UpdateCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void DeleteCustomer(string customerName)
        {
            connection = new SqlConnection(data.ConnectionString);

            var deleteCustomerCommand = new SqlCommand(data.DeleteCustomerQuerry(customerName), connection);
            var deleteCreditCard = new SqlCommand(creditCard.DeleteCreditCardData(customerName), connection);
            var deleteCustomerAccountCommand = new SqlCommand(data.DeleteCustomerAccountQuerry(customerName), connection);
            var deleteCustomerTransactionsCommand = new SqlCommand(data.DeleteCustomerTransactions(customerName), connection);

            connection.Open();

            var delete = new SqlDataAdapter();

            #region DeleteCustomer
            delete.DeleteCommand = deleteCustomerCommand;
            delete.DeleteCommand.ExecuteNonQuery();
            deleteCustomerCommand.Dispose();
            #endregion

            #region DeleteCustomerAccount
            delete.DeleteCommand = deleteCustomerAccountCommand;
            delete.DeleteCommand.ExecuteNonQuery();
            deleteCustomerAccountCommand.Dispose();
            #endregion

            #region DeleteCustomerTransactions
            delete.DeleteCommand = deleteCustomerTransactionsCommand;
            delete.DeleteCommand.ExecuteNonQuery();
            deleteCustomerTransactionsCommand.Dispose();
            #endregion

            #region DeleteCreditCard
            delete.DeleteCommand = deleteCreditCard;
            delete.DeleteCommand.ExecuteNonQuery();
            delete.Dispose();
            #endregion


            connection.Close();

        }


    }
}
