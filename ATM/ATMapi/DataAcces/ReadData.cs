using ATMapi.Config;
using ATMapi.DTOs;
using ATMapi.Modeles;
using ATMapi.src;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

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

        public SoldDTO ReadAccountInfo(string customerName,string accountNumber)
        {
            SoldDTO soldDTO;
            var readInfoCommand = new SqlCommand(QuerryStrings.SelectAccountInfo(customerName,accountNumber), _connection);

            try
            {
                _connection.Open();

                var reader = readInfoCommand.ExecuteReader();

                reader.Read();
                soldDTO = new SoldDTO(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), DateTime.Now.ToString("yyyy-MM-dd"));
                reader.Close();

                return soldDTO;

            }
            catch (Exception ex)
            {
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
