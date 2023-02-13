using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData.UpdateData
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
