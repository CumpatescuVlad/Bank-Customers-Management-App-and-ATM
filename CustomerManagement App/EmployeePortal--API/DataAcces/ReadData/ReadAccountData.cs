using EmployeePortal__API.BusinessLogic.DTOs;
using EmployeePortal__API.BusinessLogic.DTOs.TransactionsDTOs;
using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.Config;
using EmployeePortal__API.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace EmployeePortal__API.DataAcces.ReadData
{
    public class ReadAccountData : IReadAccountData
    {
        private readonly ILogger<ReadAccountData> _logger;
        private readonly ConfigurationModel _configModel;
        private readonly SqlConnection _connection;

        public ReadAccountData(ILogger<ReadAccountData> logger, IOptions<ConfigurationModel> config)
        {
            _logger = logger;
            _configModel = config.Value;
            _connection = new SqlConnection(_configModel.ConnectionString);

        }

        public List<AccountDTO> ReadAccountInfo(string customerName)
        {
            var accountsList = new List<AccountDTO>();
            var readAccountInfoCommand = new SqlCommand(QuerryStrings.Select(customerName,"AccountData"), _connection);

            try
            {
                _connection.Open();
                var reader = readAccountInfoCommand.ExecuteReader();
             
                while (reader.Read())
                {
                    accountsList.Add(new AccountDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4)));
                }

                return accountsList;
            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                accountsList.Add(new AccountDTO("No Owner Was Found", "No Account Number Was Found", "No IBAN Was Found", 0, "No Account Name Was Found"));

                return accountsList;
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


        public TransactionsDTO ReadTransactions(string customerName)
        {
            TransactionsDTO transactionsDTO;
            var atmTransactionsList = new List<ATMTransactionsDTO>();
            var incomeTransactionsList = new List<IncomeTransactionsDTO>();
            var outcomeTransactionsList = new List<OutcomeTransactionsDTO>();
            
            var readATMTransactionsCommand = new SqlCommand(QuerryStrings.SelectTransactions(customerName,"ATMTransactions"), _connection);
            var readIncomeTransactionsCommand = new SqlCommand(QuerryStrings.SelectTransactions(customerName, "IncomingTransfers"),_connection);
            var readOutcomeTransactionsCommand = new SqlCommand(QuerryStrings.SelectTransactions(customerName, "OutcomingTransfer"),_connection);
          
            try
            {
                _connection.Open();

                var atmReader = readATMTransactionsCommand.ExecuteReader();

                while (atmReader.Read())
                {
                    atmTransactionsList.Add(new ATMTransactionsDTO(atmReader.GetString(0), atmReader.GetString(1),atmReader.GetInt32(2), atmReader.GetString(3)));

                }
                atmReader.Close();
                
                var incomeReader = readIncomeTransactionsCommand.ExecuteReader();

                while (incomeReader.Read())
                {
                    incomeTransactionsList.Add(new IncomeTransactionsDTO(incomeReader.GetString(0), incomeReader.GetString(1), incomeReader.GetString(2), incomeReader.GetInt32(3), incomeReader.GetString(4)));
                }
                incomeReader.Close();

                var outcomeReader = readOutcomeTransactionsCommand.ExecuteReader();

                while (outcomeReader.Read())
                {
                    outcomeTransactionsList.Add(new OutcomeTransactionsDTO(outcomeReader.GetString(0), outcomeReader.GetString(1), outcomeReader.GetString(2), outcomeReader.GetInt32(3), outcomeReader.GetString(4)));
                }
                outcomeReader.Close();

                transactionsDTO = new TransactionsDTO(atmTransactionsList,incomeTransactionsList,outcomeTransactionsList);

                return transactionsDTO;

            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                var emptyList = new TransactionsDTO(null,null,null);

                return emptyList;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());
                _logger.LogError(ex.StackTrace);

                return null;

            }
            finally
            {
                _connection.Close();
            }

        }
    }
}
