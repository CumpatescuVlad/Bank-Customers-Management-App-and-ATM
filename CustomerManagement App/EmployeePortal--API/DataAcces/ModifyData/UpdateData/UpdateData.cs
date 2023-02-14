using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.Config;
using EmployeePortal__API.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortal__API.DataAcces.ModifyData.UpdateData
{
    public class UpdateData : IUpdateData
    {
        private readonly ConfigurationModel _config;
        private readonly SqlConnection _connection;
        private readonly ILogger<UpdateData> _logger;
        public UpdateData(IOptions<ConfigurationModel> config, ILogger<UpdateData> logger)
        {
            _config = config.Value;
            _logger = logger;
            _connection = new SqlConnection(_config.ConnectionString);

        }
        public HttpStatusCode UpdateCustomerData(UpdateDataModel updateModel)
        {
            var command = new SqlCommand(QuerryStrings.Update(updateModel), _connection);

            try
            {
                _connection.Open();
                var updateAdapter = new SqlDataAdapter { UpdateCommand = command };
                updateAdapter.UpdateCommand.ExecuteNonQuery();

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

        public HttpStatusCode UpdateCreditCard(string customerName)
        {
            var updatePinCommand = new SqlCommand(QuerryStrings.UpdatePinCode(customerName),_connection);

            try
            {
                _connection.Open();
                var updatePinAdapter = new SqlDataAdapter { UpdateCommand = updatePinCommand };

                updatePinCommand.ExecuteNonQuery();

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
