namespace EmployeeInterface
{
    public class CustomerDataQuerries
    {
        private string _connectionString =
            @"Server=tcp:vlad07072003.database.windows.net,1433;Initial Catalog=BankApp;Persist Security Info=False;
            User ID=Vlad;Password=Apicultor__69;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;
            Connection Timeout=30;";

        private string _querryString = @"Select  EmployeeName , EmployeeID , Password from Employee";

        public string ConnectionString { get => _connectionString; }

        public string QuerryString { get => _querryString; }

        public string DeleteCustomerQuerry(string customerName) => $@"Delete Customers Where  CustomerFullName ='{customerName}'";

        public string DeleteCustomerAccountQuerry(string customerName) => $@"Delete Accounts Where  CustomerName ='{customerName}'";

        public string DeleteCustomerTransactions(string customerName) => $@"Delete TransactionsTable Where  CustomerName ='{customerName}'";

        public string UpdateCustomerString(string columnName, string value, string oldCustomerName) => $"Update Customers set {columnName} ='{value}'  where CustomerFullName='{oldCustomerName}'";

        public string ReadCustomerDataString(string customerName) => $@"Select  CustomerFullName , CustomerPassword ,  CustomerEmail , CustomerPhoneNumber  from Customers Where  CustomerFullName ='{customerName}'";

    }
}
