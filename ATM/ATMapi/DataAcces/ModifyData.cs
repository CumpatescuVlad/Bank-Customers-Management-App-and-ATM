using ATMapi.BusinessLogic.Modeles;
using ATMapi.Config;
using ATMapi.PersistenceLayer;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace ATMapi.DataAcces
{
    public class ModifyData : IModifyData
    {
        private readonly ConfigurationModel _config;
        private readonly ILogger<ModifyData> _logger;
        private readonly SqlConnection _connection;

        public ModifyData(IOptions<ConfigurationModel> config, ILogger<ModifyData> logger)
        {
            _config = config.Value;
            _logger = logger;
            _connection = new SqlConnection(_config.ConnectionString);
        }

        public HttpStatusCode Deposit(DepositModel depositModel)
        {
            var insertBallanceCommand = new SqlCommand(QuerryStrings.UpdateBallance(depositModel, null, "Deposit"), _connection);

            try
            {
                _connection.Open();
                var adpter = new SqlDataAdapter() { InsertCommand = insertBallanceCommand };
                adpter.InsertCommand.ExecuteNonQuery();

                return HttpStatusCode.Created;
            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return HttpStatusCode.NotFound;

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

        public HttpStatusCode Withdraw(WithdrawModel withdrawModel)
        {
            var insertBallanceCommand = new SqlCommand(QuerryStrings.UpdateBallance(null, withdrawModel, "Withdraw"), _connection);

            try
            {
                _connection.Open();

                var adpter = new SqlDataAdapter() { InsertCommand = insertBallanceCommand };

                adpter.InsertCommand.ExecuteNonQuery();

                return HttpStatusCode.Continue;
            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return HttpStatusCode.NotFound;
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

        public HttpStatusCode InsertTransaction(TransactionModel transactionModel)
        {
            var insertBallanceCommand = new SqlCommand(QuerryStrings.InsertTransaction(transactionModel), _connection);

            try
            {
                _connection.Open();

                var adpter = new SqlDataAdapter() { InsertCommand = insertBallanceCommand };

                adpter.InsertCommand.ExecuteNonQuery();

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
