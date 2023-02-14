using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.Config;
using EmployeePortal__API.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortal__API.DataAcces.ModifyData.DeleteData
{
    public class DeleteData : IDeleteData
    {
        private readonly ConfigurationModel _config;
        private readonly SqlConnection _connection;
        private readonly ILogger<DeleteData> _logger;
        public DeleteData(IOptions<ConfigurationModel> config, ILogger<DeleteData> logger)
        {
            _config = config.Value;
            _logger = logger;
            _connection = new SqlConnection(_config.ConnectionString);

        }

        public HttpStatusCode DeleteCustomer(string customerName)
        {
            var deleteCustomerDataCommand = new SqlCommand(QuerryStrings.Delete(customerName, "Customers"), _connection);
            var deleteAccountCommand = new SqlCommand(QuerryStrings.Delete(customerName, "PersonalAccounts"), _connection);
            var deleteATMTransactionsCommand = new SqlCommand(QuerryStrings.Delete(customerName, "ATMTransactions"), _connection);
            var deleteIncomeTransfersCommand = new SqlCommand(QuerryStrings.Delete(customerName, "IncomingTransfers"), _connection);
            var deleteOutcomeTransfersCommand = new SqlCommand(QuerryStrings.Delete(customerName, "OutcomingTransfers"), _connection);
            try
            {
                _connection.Open();
                var deleteAdapter = new SqlDataAdapter();

                deleteAdapter.DeleteCommand = deleteCustomerDataCommand; deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteAccountCommand; deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteATMTransactionsCommand; deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteIncomeTransfersCommand; deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteOutcomeTransfersCommand; deleteAdapter.DeleteCommand.ExecuteNonQuery();


                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());

                return HttpStatusCode.InternalServerError;
            }
            finally
            {
                _connection.Close();
            }
        }

        public HttpStatusCode DeleAccount(DeleteAccountModel deleteAccountModel)
        {
            var deleteAccountCommand = new SqlCommand(QuerryStrings.DeleteAccount(deleteAccountModel), _connection);
            var deleteATMTransactionsCommand = new SqlCommand(QuerryStrings.Delete(deleteAccountModel.CustomerName,"ATMTransactions"), _connection);
            var deleteIncomingTransfersCommand = new SqlCommand(QuerryStrings.Delete(deleteAccountModel.CustomerName,"IncomingTransfers"), _connection);
            var deleteOutcomingTransfersCommand = new SqlCommand(QuerryStrings.Delete(deleteAccountModel.CustomerName,"OutcomingTransfers"), _connection);

            try
            {
                _connection.Open();
                var adapter = new SqlDataAdapter();

                adapter.DeleteCommand = deleteAccountCommand; adapter.DeleteCommand.ExecuteNonQuery();
                adapter.DeleteCommand = deleteATMTransactionsCommand; adapter.DeleteCommand.ExecuteNonQuery();
                adapter.DeleteCommand = deleteIncomingTransfersCommand; adapter.DeleteCommand.ExecuteNonQuery();
                adapter.DeleteCommand = deleteOutcomingTransfersCommand; adapter.DeleteCommand.ExecuteNonQuery();

                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());

                return HttpStatusCode.InternalServerError;
            }
            finally
            {
                _connection.Close();
            }

        }
    }
}
