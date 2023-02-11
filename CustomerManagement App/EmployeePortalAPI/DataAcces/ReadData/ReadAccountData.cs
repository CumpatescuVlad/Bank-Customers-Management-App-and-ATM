using EmployeePortalAPI.BusinessLogic.DTOs;
using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;


namespace EmployeePortalAPI.DataAcces.CustomerData
{
    public class ReadAccountData
    {
        private readonly ILogger<ReadAccountData> _logger;
        private readonly ConfigModel _configModel;
        private readonly SqlConnection _connection;

        public ReadAccountData(ILogger<ReadAccountData> logger, IOptions<ConfigModel> config)
        {
            _logger = logger;
            _configModel = config.Value;
            _connection = new SqlConnection(_configModel.ConnectionString);

        }

        public AccountDTO ReadAccountInfo(string customerName)
        {
            AccountDTO accountDTO;
            var readAccountInfoCommand = new SqlCommand(QuerryStrings.ReadAccount(customerName), _connection);

            try
            {
                _connection.Open();
                var reader = readAccountInfoCommand.ExecuteReader();
                reader.Read();
                accountDTO = new AccountDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                reader.Close();

                return accountDTO;
            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return new AccountDTO("No Owner Was Found", "No Account Number Was Found", "No IBAN Was Found", 0, "No Account Name Was Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());

                return null;

            }
            finally
            {
                _connection.Close();
            }

        }


        public TransactionsDTO ReadTransactions(TransactionModel transactionModel)
        {
            TransactionsDTO? transactions = null;
            var readTransactionsCommand = new SqlCommand(QuerryStrings.SelectTransactions(transactionModel), _connection);

            try
            {
                _connection.Open();

                var reader = readTransactionsCommand.ExecuteReader();

                while (reader.Read())
                {
                    transactions = new TransactionsDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));

                }
                reader.Close();

                return transactions;

            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return transactions = new TransactionsDTO("No Owner Was Found", "No Account Number Was Found", "No IBAN Was Found", "No Account Name Was Found", 0, "No Date Was Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());

                return null;

            }
            finally
            {
                _connection.Close();
            }



        }

    }
}
