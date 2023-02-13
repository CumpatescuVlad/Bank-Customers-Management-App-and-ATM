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
            var deleteCustomerDataCommand = new SqlCommand(QuerryStrings.Delete(customerName, "Customer"), _connection);
            var deleteAccountCommand = new SqlCommand(QuerryStrings.Delete(customerName, "Accounts"), _connection);
            var deleteTransactionsCommand = new SqlCommand(QuerryStrings.Delete(customerName, "Transactions"), _connection);
            try
            {
                _connection.Open();

                var deleteAdapter = new SqlDataAdapter();
                deleteAdapter.DeleteCommand = deleteCustomerDataCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteAccountCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteTransactionsCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                

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

            var deleteTransactionsCommand = new SqlCommand(QuerryStrings.DeleteTransactions(deleteAccountModel), _connection);
            try
            {
                _connection.Open();

                var adapter = new SqlDataAdapter();

                adapter.DeleteCommand = deleteAccountCommand;
                adapter.DeleteCommand.ExecuteNonQuery();

                adapter.DeleteCommand = deleteTransactionsCommand;
                adapter.DeleteCommand.ExecuteNonQuery();

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
