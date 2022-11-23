using ATM.Data;
using Microsoft.Data.SqlClient;

namespace ATM.App_functionality
{
    public class ATMOperations
    {
        DataSource data = new DataSource();
        SqlConnection connection = null;
        Temp temp = new();
        public void ReadCreditCardData(string creditCardNumber)
        {
            using (connection = new SqlConnection(data.ConnectionString))
            {
                connection.Open();
                using var readCreditCardDataCommand = new SqlCommand(data.CreditCardInfo(creditCardNumber), connection);
                using (var reader = readCreditCardDataCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp.CreateFile("CustomerName.txt", $"{reader.GetValue(0)}");
                        temp.CreateFile("CreditCardNumber.txt", $"{reader.GetValue(1)}");
                        temp.CreateFile("CreditCardPIN.txt", $"{reader.GetValue(2)}");
                        temp.CreateFile("AccountIBAN.txt", $"{reader.GetValue(3)}");
                    }

                    reader.Close();

                }
                using (var customerAccountDataCommand = new SqlCommand(data.ReadCustomerAccountData(temp.ReadFile("AccountIBAN.txt")), connection))
                {
                    using var accountDataReader = customerAccountDataCommand.ExecuteReader();
                    while (accountDataReader.Read())
                    {
                        temp.CreateFile("AccountNumber.txt", $"{accountDataReader.GetValue(0)}");
                        temp.CreateFile("AccountName.txt", $"{accountDataReader.GetValue(1)}");

                    }

                }
                connection.Close();

            }

        }

        public string Sold(string IBAN)
        {
            connection = new SqlConnection(data.ConnectionString);

            var readAccountDataCommand = new SqlCommand(data.ReadAccountAmount(IBAN), connection);

            connection.Open();

            var reader = readAccountDataCommand.ExecuteReader();

            string amount = "";

            while (reader.Read())
            {
                amount = $"{reader.GetValue(0)}";

            }

            connection.Close();

            return amount;
        }
        public void Withdraw(string IBAN, int amount)
        {
            connection = new SqlConnection(data.ConnectionString);

            var withdrawCommand = new SqlCommand(data.UpdateAmount(IBAN, amount), connection);
            connection.Open();

            var adapter = new SqlDataAdapter { UpdateCommand = withdrawCommand };

            adapter.UpdateCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Deposit(string IBAN, int amount)
        {
            connection = new SqlConnection(data.ConnectionString);

            var depositCommand = new SqlCommand(data.UpdateAmount(IBAN, amount), connection);

            connection.Open();

            var adapter = new SqlDataAdapter { UpdateCommand = depositCommand };

            adapter.UpdateCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void InsertTransactionRecord(string IBAN, int amount, string transactionType)
        {
            connection = new SqlConnection(data.ConnectionString);

            var insertTransaction = new SqlCommand(data.InsertTransactionRecord(IBAN, amount, transactionType), connection);

            connection.Open();

            var insert = new SqlDataAdapter { InsertCommand = insertTransaction };

            insert.InsertCommand.ExecuteNonQuery();

            connection.Close();

        }

    }
}
