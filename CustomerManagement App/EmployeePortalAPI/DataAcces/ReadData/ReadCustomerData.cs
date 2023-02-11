using EmployeePortalAPI.BusinessLogic.DTOs;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.DataAcces.ReadData;
using EmployeePortalAPI.Persistence;
using Microsoft.Data.SqlClient;


namespace EmployeePortalAPI.DataAcces.CustomerData
{
    public class ReadCustomerData : IReadCustomerData
    {
        private readonly ConfigModel _config;
        private readonly ILogger<ReadCustomerData> _logger;
        private readonly SqlConnection _connection;

        public ReadCustomerData(ConfigModel config, ILogger<ReadCustomerData> logger)
        {
            _config = config;
            _logger = logger;
            _connection = new SqlConnection(_config.ConnectionString);
        }

        public string ReadCustomer(string customerName)
        {
            string customer;
            var readCustomerCommand = new SqlCommand(QuerryStrings.SelectCustomer(customerName), _connection);

            try
            {
                _connection.Open();
                var reader = readCustomerCommand.ExecuteReader();
                reader.Read();
                customer = reader.GetString(0);
                reader.Close();

                return customer;

            }
            catch (InvalidOperationException invalidEx)
            {
                _logger.LogError(invalidEx.Message);

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.GetType().ToString());

                return "Error";
            }
            finally
            {
                _connection.Close();

            }
        }

        public CustomerDataDTO ReadCustomerInfo(string customerName)
        {
            CustomerDataDTO customerDto;
            var readCustomerCommand = new SqlCommand(QuerryStrings.SelectCustomerData(customerName), _connection);

            try
            {
                _connection.Open();
                var reader = readCustomerCommand.ExecuteReader();
                reader.Read();
                customerDto = new CustomerDataDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                reader.Close();

                return customerDto;

            }
            catch (InvalidOperationException invalidException)
            {
                _logger.LogError(invalidException.Message);

                return new CustomerDataDTO("Not Found", "Not found", "Not Found");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.GetType().ToString());
                _logger.LogError(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

        }


    }
}
