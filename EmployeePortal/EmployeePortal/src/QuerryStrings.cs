namespace EmployeePortal.src
{
    public class QuerryStrings
    {
        public static string SelectCustomer(string customerName) => $@"Select  CustomerFullName , CustomerPassword ,  CustomerEmail , CustomerPhoneNumber  from Customers Where  CustomerFullName ='{customerName}'";

        public static string SelectEmployeeCredentials() => "Select EmployeeID,EmployeePassword From Employee";

        public static string Update(string columnName, string value, string oldCustomerName) => $"Update Customers Set {columnName} ='{value}'  Where CustomerFullName='{oldCustomerName}'";

        public static string Delete(string customerName,string tableToDelete)
        {
            string querryString;

            if (tableToDelete == "Customers")
            {
                querryString = $"Delete CustomersTable Where  CustomerFullName ='{customerName}'";
            }
            else if (tableToDelete== "Accounts")
            {
                querryString = $"Delete AccountsTable Where  CustomerName ='{customerName}'";
            }
            else if(tableToDelete == "CreditCard")
            {
                querryString= $"Delete CreditCardTable Where  CustomerName ='{customerName}'";
            }
            else
            {
                querryString = $"Delete TransactionsTable Where  CustomerName ='{customerName}'";
            }
            return querryString;
        }
    }
}
