using System;
using System.Data.SqlClient;
using EmployeePortal.Modeles;
using Newtonsoft.Json;
using System.IO;
using EmployeePortal.src;
using System.Windows.Forms;

namespace EmployeePortal.DataAccesLayer
{
    public class ModifyData
    {
        private readonly Config.Config _config = JsonConvert.DeserializeObject<Config.Config>(File.ReadAllText($@"{Environment.CurrentDirectory}\Config\config.json"));

        public string UpdateCustomerData(UpdateDataModel updateModel)
        {
           var connection = new SqlConnection(_config.ConnectionString);
           var command = new SqlCommand(QuerryStrings.Update(updateModel.ColumnName,updateModel.Value,updateModel.OldCustomerName), connection);
            try
            {
                connection.Open();
                var updateAdapter = new SqlDataAdapter { UpdateCommand = command };
                updateAdapter.UpdateCommand.ExecuteNonQuery();
                return "Succesfully Updated";

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred.");
                return null;
            }
            finally
            {
                connection.Close();
            }
           
        }

        public string DeleteCustomer(string customerName)
        {
            var connection = new SqlConnection(_config.ConnectionString);

            var deleteCustomerDataCommand = new SqlCommand(QuerryStrings.Delete(customerName,"CustomersTable"), connection);
            var deleteCreditCardCommand = new SqlCommand(QuerryStrings.Delete(customerName, "CreditCardTable"), connection);
            var deleteAccountCommand = new SqlCommand(QuerryStrings.Delete(customerName, "AccountsTable"), connection);
            var deleteTransactionsCommand = new SqlCommand(QuerryStrings.Delete(customerName, "TransactionsTable"), connection);
            try
            {
                connection.Open();
                var deleteAdapter = new SqlDataAdapter();
                deleteAdapter.DeleteCommand = deleteCustomerDataCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteCreditCardCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteAccountCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();
                deleteAdapter.DeleteCommand = deleteTransactionsCommand;
                deleteAdapter.DeleteCommand.ExecuteNonQuery();

                return "Customer Succesfully Deleted";
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
