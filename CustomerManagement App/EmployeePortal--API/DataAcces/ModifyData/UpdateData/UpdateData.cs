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
            var updateNameCommand = new SqlCommand(QuerryStrings.Update(updateModel, "Customers"), _connection);
            var updateAccountCommand = new SqlCommand(QuerryStrings.Update(updateModel, "PersonalAccounts"), _connection);
            var updateCreditCardCommand = new SqlCommand(QuerryStrings.Update(updateModel, "CreditCard"), _connection);
            var updateBankingAppCommand = new SqlCommand(QuerryStrings.Update(updateModel, "BankingApp"), _connection);
            
            try
            {
                _connection.Open();
                var updateAdapter = new SqlDataAdapter();
                if (updateModel.ColumnName is "CustomerName")
                {
                    updateAdapter.UpdateCommand = updateNameCommand; updateAdapter.UpdateCommand.ExecuteNonQuery();
                    updateAdapter.UpdateCommand = updateAccountCommand; updateAdapter.UpdateCommand.ExecuteNonQuery();
                    updateAdapter.UpdateCommand = updateCreditCardCommand; updateAdapter.UpdateCommand.ExecuteNonQuery();
                    updateAdapter.UpdateCommand = updateBankingAppCommand; updateAdapter.UpdateCommand.ExecuteNonQuery();

                    return HttpStatusCode.OK;
                }
                else
                {
                    updateAdapter.UpdateCommand = updateNameCommand; updateAdapter.UpdateCommand.ExecuteNonQuery();

                    return HttpStatusCode.OK;
                }
                
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
            var updatePinCommand = new SqlCommand(QuerryStrings.UpdatePinCode(customerName), _connection);

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
