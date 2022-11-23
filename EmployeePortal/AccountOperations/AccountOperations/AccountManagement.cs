using EmployeeInterface;
using System.Data.SqlClient;


namespace AccountOperations
{
    public class AccountManagement
    {
        #region Objects
        private readonly CustomerDataQuerries data = new CustomerDataQuerries();
        private readonly AccountDataQuerries querry = new AccountDataQuerries();
        private SqlConnection connection = null;
        private SqlDataReader reader = null;

        #endregion

        public void CreateAccount(string customerName, string accountName, int amount)
        {
            connection = new SqlConnection(data.ConnectionString);

            var insertAccount = new SqlCommand(querry.InsertAccount(customerName, amount, accountName), connection);

            connection.Open();

            var insert = new SqlDataAdapter { InsertCommand = insertAccount };

            insert.InsertCommand.ExecuteNonQuery();

            connection.Close();


        }

        public string DisplayAccounts(string customerName)
        {

            connection = new SqlConnection(data.ConnectionString);

            var readAccounts = new SqlCommand(querry.ReadAccounts(customerName), connection);

            string output = null;

            connection.Open();

            reader = readAccounts.ExecuteReader();

            while (reader.Read())
            {
                output += $"{reader.GetValue(0)}\t   {reader.GetValue(1)}\t\t            {reader.GetValue(2)}\t\t     {reader.GetValue(3)}\t\t     {reader.GetValue(4)}\n";

            }

            connection.Close();

            return output;

        }
        public string ShowDefaultTransactions(string customerName, string accountNumber)
        {
            connection = new SqlConnection(data.ConnectionString);

            var showDefaultTransactions = new SqlCommand(querry.DisplayAccountTransactions(customerName, accountNumber), connection);

            string output = null;

            connection.Open();

            var defaultReader = showDefaultTransactions.ExecuteReader();

            while (defaultReader.Read())
            {
                output += $"{defaultReader.GetValue(0)}\t  {defaultReader.GetValue(1)}\t\t {defaultReader.GetValue(3)}\t\t        {defaultReader.GetValue(4)}\t\t {defaultReader.GetValue(5)}\n";

                Temp.CreateFile("CustomerFullName.txt", $"{defaultReader.GetValue(0)}");
                Temp.CreateFile("AccountNumber.txt", $"{defaultReader.GetValue(1)}");
                Temp.CreateFile("AccountIBAN.txt", $"{defaultReader.GetValue(2)}");
                Temp.CreateFile("AccountName.txt", $"{defaultReader.GetValue(3)}");


            }

            connection.Close();

            return output;
        }
        public void ShowTransactionsOrdered(string customerName, string accountNumber, string order)
        {
            connection = new SqlConnection(data.ConnectionString);

            var showTransactionsByValue = new SqlCommand(querry.DisplayAccountTransactionsOrdered(customerName, accountNumber, order), connection);

            string orderedByValue = null;

            int total = 0;

            connection.Open();

            var readByValue = showTransactionsByValue.ExecuteReader();

            while (readByValue.Read())
            {
                orderedByValue += $"{readByValue.GetValue(4)}\t\t{readByValue.GetValue(5)}\n";

                Temp.CreateFile($"TransactionsOrderedBy{order}.txt", orderedByValue);
                total += int.Parse($"{readByValue.GetValue(4)}");
                Temp.CreateFile("Total.txt", $"{total}");
            }
            connection.Close();

        }

        public void DeleteAccount(string customerName, string accountNumber)
        {
            connection = new SqlConnection(data.ConnectionString);

            var deleteAccount = new SqlCommand(querry.DeleteAccount(customerName, accountNumber), connection);

            var deleteTransactions = new SqlCommand(querry.DeleteTransactions(customerName, accountNumber), connection);

            connection.Open();

            var adapter = new SqlDataAdapter();

            adapter.DeleteCommand = deleteAccount;
            adapter.DeleteCommand.ExecuteNonQuery();

            adapter.DeleteCommand = deleteTransactions;
            adapter.DeleteCommand.ExecuteNonQuery();

            connection.Close();


        }
        public void CreateCompanyAccount(string companyName, string companyServices)
        {
            connection = new SqlConnection(data.ConnectionString);

            var createCompany = new SqlCommand(querry.InsertCompany(companyName, companyServices), connection);

            connection.Open();

            var adapter = new SqlDataAdapter
            {
                InsertCommand = createCompany
            };

            adapter.InsertCommand.ExecuteNonQuery();

            connection.Close();



        }
    }
}
