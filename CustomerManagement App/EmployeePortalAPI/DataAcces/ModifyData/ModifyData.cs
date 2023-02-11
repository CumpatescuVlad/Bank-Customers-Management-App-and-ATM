using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.BusinessLogic.Models;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData
{
    public class ModifyData
    {
        private readonly ConfigModel _config;
        private readonly SqlConnection _connection;
        private readonly ILogger<ModifyData> _logger;
        public ModifyData(IOptions<ConfigModel> config, ILogger<ModifyData> logger)
        {
            _config = config.Value;
            _connection = new SqlConnection(_config.ConnectionString);
            _logger = logger;
        }

        public HttpStatusCode InsertCustomer(CustomerModel customerModel)
        {
            var insertCustomerCommand = new SqlCommand(QuerryStrings.Insert(customerModel), _connection);

            try
            {
                _connection.Open();
                var adapter = new SqlDataAdapter() { InsertCommand = insertCustomerCommand };

                adapter.InsertCommand = insertCustomerCommand;
                adapter.InsertCommand.ExecuteNonQuery();

                return HttpStatusCode.Created;
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

        public HttpStatusCode InsertBankAccount(CreateAccountModel createAccountModel)
        {
            var insertAccountCommand = new SqlCommand(QuerryStrings.InsertAccount(createAccountModel), _connection);

            try
            {
                _connection.Open();

                var insert = new SqlDataAdapter { InsertCommand = insertAccountCommand };

                insert.InsertCommand.ExecuteNonQuery();

                return HttpStatusCode.Created;

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

        public HttpStatusCode UpdateCustomerData(UpdateDataModel updateModel)
        {
            var command = new SqlCommand(QuerryStrings.Update(updateModel), _connection);

            try
            {
                _connection.Open();
                var updateAdapter = new SqlDataAdapter { UpdateCommand = command };
                updateAdapter.UpdateCommand.ExecuteNonQuery();

                return HttpStatusCode.Created;
                
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
