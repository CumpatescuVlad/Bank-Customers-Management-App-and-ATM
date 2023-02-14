using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.Config;
using EmployeePortal__API.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortal__API.DataAcces.ModifyData.InsertData
{
    public class InsertData : IInsertData
    {
        private readonly ConfigurationModel _config;
        private readonly SqlConnection _connection;
        private readonly ILogger<InsertData> _logger;
        public InsertData(IOptions<ConfigurationModel> config, ILogger<InsertData> logger)
        {
            _config = config.Value;
            _logger = logger;
            _connection = new SqlConnection(_config.ConnectionString);

        }

        public HttpStatusCode InsertCustomer(CustomerModel customerModel)
        {
            var insertCustomerCommand = new SqlCommand(QuerryStrings.Insert(customerModel,"Customers"), _connection);
            var insertAccountCommand = new SqlCommand(QuerryStrings.Insert(customerModel,"PersonalAccounts"),_connection);
            var insertCreditCardCommand = new SqlCommand(QuerryStrings.Insert(customerModel,"CreditCard"),_connection);
            var insertBankingAppCommand = new SqlCommand(QuerryStrings.Insert(customerModel, "BankingApp"),_connection);

            try
            {
                _connection.Open();
                var adapter = new SqlDataAdapter() { InsertCommand = insertCustomerCommand };

                adapter.InsertCommand = insertCustomerCommand; adapter.InsertCommand.ExecuteNonQuery();
                adapter.InsertCommand = insertAccountCommand; adapter.InsertCommand.ExecuteNonQuery();
                adapter.InsertCommand = insertCreditCardCommand; adapter.InsertCommand.ExecuteNonQuery();
                adapter.InsertCommand = insertBankingAppCommand; adapter.InsertCommand.ExecuteNonQuery();

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

    }
}
