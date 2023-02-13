﻿using EmployeePortal__API.BusinessLogic.DTOs;
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


        public List<TransactionsDTO> ReadTransactions(TransactionModel transactionModel)
        {
            var transactionsList = new List<TransactionsDTO>();
            
            var readTransactionsCommand = new SqlCommand(QuerryStrings.SelectTransactions(transactionModel), _connection);
            
            try
            {
                _connection.Open();

                var reader = readTransactionsCommand.ExecuteReader();

                while (reader.Read())
                {
                    transactionsList.Add(new TransactionsDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5)));

                }
                reader.Close();

                return transactionsList;

            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return transactionsList;

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
