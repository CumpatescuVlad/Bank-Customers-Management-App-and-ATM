using EmployeePortal.DTOs;
using EmployeePortal.Modeles;
using EmployeePortal.src;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeePortal.DataAccesLayer
{
    public class ReadData
    {
        private readonly Config.Config _config = new Config.Config();

        public CustomerDataDTO ReadCustomer(string customerName)
        {
            CustomerDataDTO customerData;
            var conenction = new SqlConnection(_config.ConnectionString);
            var readCommand = new SqlCommand(QuerryStrings.ReadAccount(customerName), conenction);

            try
            {
                conenction.Open();
                var reader = readCommand.ExecuteReader();
                reader.Read();
                customerData = new CustomerDataDTO(reader.GetString(0), reader.GetString(1), reader.GetString(3), reader.GetString(4));
                reader.Close();

                return customerData;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;

            }
            finally
            {
                conenction.Close();
            }






        }

        public EmployeeCredentialsDTO ReadEmployeeData()
        {
            EmployeeCredentialsDTO employeeCredentials;
            var connection = new SqlConnection(_config.ConnectionString);
            var credentialsCommand = new SqlCommand(QuerryStrings.SelectEmployeeCredentials(), connection);

            try
            {
                connection.Open();
                var reader = credentialsCommand.ExecuteReader();
                return new EmployeeCredentialsDTO(reader.GetString(0), reader.GetString(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                connection.Close();
            }


        }
        public AccountDTO ReadAccounts(string customerName)
        {
            AccountDTO account = null;
            var connection = new SqlConnection(_config.ConnectionString);
            var readAccountCommand = new SqlCommand(QuerryStrings.ReadAccount(customerName), connection);

            try
            {
                connection.Open();
                var reader = readAccountCommand.ExecuteReader();
                while (reader.Read())
                {
                    account = new AccountDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));

                }
                connection.Close();

                return account;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public TransactionsDTO ReadTransactions(TransactionModel transactionModel)
        {
            TransactionsDTO transactions = null;
            var connection = new SqlConnection(_config.ConnectionString);
            var readTransactionsCommand = new SqlCommand(QuerryStrings.SelectTransactions(transactionModel), connection);

            try
            {
                connection.Open();

                var reader = readTransactionsCommand.ExecuteReader();

                while (reader.Read())
                {
                    transactions = new TransactionsDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));

                }
                return transactions;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;

            }
            finally
            {
                connection.Close();
            }

        }

    }
}
