using System.Data.SqlClient;

namespace EmployeeInterface
{
    public class ReadEmployeeData
    {
        private readonly CustomerDataQuerries data = new CustomerDataQuerries();

        public void EmployeeData()
        {

            using (var connection = new SqlConnection(data.ConnectionString))
            {
                connection.Open();

                using (var readEmployeeCredentials = new SqlCommand(data.QuerryString, connection))
                {
                    var credentialsReader = readEmployeeCredentials.ExecuteReader();

                    using (credentialsReader)
                    {
                        while (credentialsReader.Read())
                        {

                            Temp.CreateFile("EmployeeID.txt", $@"{credentialsReader.GetValue(1)}");
                            Temp.CreateFile("EmployeePassword.txt", $@"{credentialsReader.GetValue(2)}");

                        }

                    }

                }

                connection.Close();
            }

        }

    }
}
