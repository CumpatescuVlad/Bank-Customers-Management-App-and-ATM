using ATMapi.BusinessLogic.DTOs;
using ATMapi.Config;
using ATMapi.PersistenceLayer;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;

namespace ATMapi.DataAcces
{
    public class ReadData : IReadData
    {
        private readonly ILogger<ReadData> _logger;
        private readonly ConfigurationModel _config;
        private readonly SqlConnection _connection;
        public ReadData(ILogger<ReadData> logger, IOptions<ConfigurationModel> config)
        {
            _logger = logger;
            _config = config.Value;
            _connection = new SqlConnection(_config.ConnectionString);
        }

        public SoldDTO ReadAccountInfo(string customerName, string accountNumber)
        {
            SoldDTO soldDTO;
            var readAccountInfoCommand = new SqlCommand(QuerryStrings.SelectAccountInfo(customerName, accountNumber), _connection);

            try
            {
                _connection.Open();

                var reader = readAccountInfoCommand.ExecuteReader();

                reader.Read();
                soldDTO = new SoldDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), DateTime.Now.ToString("yyyy-MM-dd"));
                reader.Close();

                return soldDTO;

            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);
                _logger.LogError(invalidEx.GetType().ToString());

                return new SoldDTO("Not Found", "Not Found", "Not Found", null, DateTime.Now.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());
                return null;
            }
            finally
            {
                _connection.Close();
            }

        }

        public PinDTO ReadCustomerATMPin(string customerName)
        {
            var readCustomerPinCommand = new SqlCommand(QuerryStrings.SelectCustomerPin(customerName), _connection);
            PinDTO pinDTO;
            try
            {
                _connection.Open();

                var reader = readCustomerPinCommand.ExecuteReader();

                reader.Read();
                pinDTO = new PinDTO(reader.GetInt32(0));
                reader.Close();

                return pinDTO;
            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return new PinDTO(0);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());

                return null;
            }
            finally
            {
                _connection.Close();
            }


        }

        public HttpStatusCode ReadCustomer(string customerName)
        {
            var readCustomerName = new SqlCommand(QuerryStrings.SelectCustomer(customerName), _connection);

            try
            {
                _connection.Open();
                var reader = readCustomerName.ExecuteReader();

                reader.Read();
                reader.GetString(0);
                reader.Close();

                return HttpStatusCode.OK;
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
                _logger.LogWarning(ex.StackTrace);

                return HttpStatusCode.InternalServerError;
            }
            finally
            {
                _connection.Close();
            }

        }
    }
}
