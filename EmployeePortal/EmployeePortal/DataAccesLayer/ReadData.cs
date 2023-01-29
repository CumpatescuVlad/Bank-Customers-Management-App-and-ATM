using EmployeeInterface;
using EmployeePortal.DTOs;
using EmployeePortal.src;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;


namespace EmployeePortal.DataAccesLayer
{
    public class ReadData
    {
        private readonly Config.Config _config = new Config.Config();
        public EmployeeCredentialsDTO EmployeeData()
        {
            EmployeeCredentialsDTO employeeCredentials;
            var connection = new SqlConnection(_config.ConnectionString);
            var credentialsCommand = new SqlCommand(QuerryStrings.SelectEmployeeCredentials(),connection);

            try
            {
                connection.Open();
                var reader = credentialsCommand.ExecuteReader();
                return new EmployeeCredentialsDTO(reader.GetString(0),reader.GetString(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                
            }
            finally
            {
                connection.Close();
            }
                

        }

    }
}
