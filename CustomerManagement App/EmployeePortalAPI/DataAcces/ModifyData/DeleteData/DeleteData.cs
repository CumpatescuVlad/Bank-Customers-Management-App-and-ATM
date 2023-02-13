using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData.DeleteData
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
            var deleteCustomerDataCommand = new SqlCommand(QuerryStrings.Delete(customerName, "CustomersTable"), _connection);
            var deleteCreditCardCommand = new SqlCommand(QuerryStrings.Delete(customerName, "CreditCardTable"), _connection);
            var deleteAccountCommand = new SqlCommand(QuerryStrings.Delete(customerName, "AccountsTable"), _connection);
            var deleteTransactionsCommand = new SqlCommand(QuerryStrings.Delete(customerName, "TransactionsTable"), _connection);
            try
            {
                _connection.Open();
                var deleteAdapter = new SqlDataAdapter();
                deleteAdapter.DeleteCommand = deleteCustomerDataCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteCreditCardCommand;
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
