using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData.InsertData
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

    }
}
