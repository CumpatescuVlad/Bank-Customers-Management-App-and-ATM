using EmployeePortal__API.BusinessLogic.DTOs;
using EmployeePortal__API.Config;
using EmployeePortal__API.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace EmployeePortal__API.DataAcces.ReadData
{
    public class ReadCustomerData : IReadCustomerData
    {
        private readonly ConfigurationModel _config;
        private readonly ILogger<ReadCustomerData> _logger;
        private readonly SqlConnection _connection;

        public ReadCustomerData(IOptions<ConfigurationModel> config, ILogger<ReadCustomerData> logger)
        {
            _config = config.Value;
            _logger = logger;
            _connection = new SqlConnection(_config.ConnectionString);
        }

        public CustomerDataDTO ReadCustomerInfo(string customerName)
        {
            CustomerDataDTO customerDto;
            var readCustomerCommand = new SqlCommand(QuerryStrings.Select(customerName, "CustomerData"), _connection);

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

        public string ReadCustomer(string customerName)
        {
            string customer;
            var readCustomerCommand = new SqlCommand(QuerryStrings.Select(customerName, "CustomerName"), _connection);

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

                return "Not Found";
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




    }
}
