using EmployeePortalAPI.BusinessLogic.Modeles;

namespace EmployeePortalAPI.Persistence
{
    public class QuerryStrings
    {
        public static string Insert(CustomerModel customer) => $"Insert Into Customer (CustomerFullName,CustomerPassword,CustomerPhoneNumber,CustomerEmail,CustomerPin) Values ('{customer.CustomerName}','{GenerateSecurityElements.GenerateElement("Password")}','{customer.CustomerPhoneNumber}','{customer.CustomerEmail}','{GenerateSecurityElements.GenerateElement("AppPin")}')";
        public static string SelectCustomer(string customerName) => $"Select CustomerFullName From Customer Where CustomerFullName='{customerName}'";
        public static string SelectCustomerData(string customerName) => $"Select CustomerFullName,CustomerPhoneNumber,CustomerEmail From Customer Where CustomerFullName='{customerName}'";
        public static string SelectTransactions(TransactionModel transactionModel) => $"Select AccountOwnerName , AccountNumber ,AccountIBAN, AccountName , Amount , Date From TransactionsTable Where AccountOwnerName='{transactionModel.AccountOwnerName}' And AccountNumber='{transactionModel.AccountNumber}' Order By {transactionModel.Order}";
       
        public static string InsertAccount(CreateAccountModel accountModel)
        {
            string querryString;

            if (accountModel.TypeOfAccount == "PersonalAccount")
            {
                querryString = $"Insert Into PersonalAccountsTable (CustomerName,AccountName,AccountNumber,AccountIBAN,Ballance) Values ('{accountModel.AccountOwnerName}','{accountModel.AccountName}','{accountModel.AccountNumber}','{accountModel.AccountIBAN}','{accountModel.Ballance}')";
            }
            else
            {
                querryString = $"Insert Into BusinessAccountsTable (CustomerName,AccountName,AccountNumber,AccountIBAN,Ballance) Values ('{accountModel.AccountOwnerName}','{accountModel.AccountName}','{accountModel.AccountNumber}','{accountModel.AccountIBAN}','{accountModel.Ballance}')";
            }
            return querryString;
        }

        public static string DeleteAccount(DeleteAccountModel deleteAccountModel)
        {
            string querryString;

            if (deleteAccountModel.TypeOfAccount == "PersonalAccount")
            {
                querryString = $"Delete PersonalAccountsTable Where CustomerName='{deleteAccountModel.AccountOwnerName}' AND AccountName='{deleteAccountModel.AccountName}' AND AccountNumber ='{deleteAccountModel.AccountNumber}'";
            }
            else
            {
                querryString = $"Delete BusinessAccountsTable Where AccountOwnerName='{deleteAccountModel.AccountOwnerName}' AND AccountName='{deleteAccountModel.AccountName}' AND AccountNumber ='{deleteAccountModel.AccountNumber}'";
            }

            return querryString;
        }
        public static string ReadAccount(string customerName) => $"Select CustomerName,AccountIBAN,AccountNumber,Ballance,AccountName  From Accounts Where CustomerName='{customerName}'";

        public static string DeleteTransactions(DeleteAccountModel deleteAccountModel) => $"Delete TransactionsTable Where AccountOwnerName='{deleteAccountModel.AccountOwnerName}' AND AccountName='{deleteAccountModel.AccountName}' AND AccountNumber ='{deleteAccountModel.AccountNumber}'";

        public static string Update(UpdateDataModel update) => $"Update Customers Set {update.ColumnName} ='{update.Value}'  Where CustomerFullName='{update.OldCustomerName}'";

        public static string Delete(string customerName, string tableToDelete)
        {
            string querryString;

            if (tableToDelete == "Customers")
            {
                querryString = $"Delete CustomersTable Where  CustomerFullName ='{customerName}'";
            }
            else if (tableToDelete == "Accounts")
            {
                querryString = $"Delete AccountsTable Where  CustomerName ='{customerName}'";
            }
            else if (tableToDelete == "CreditCard")
            {
                querryString = $"Delete CreditCardTable Where  CustomerName ='{customerName}'";
            }
            else
            {
                querryString = $"Delete TransactionsTable Where  CustomerName ='{customerName}'";
            }
            return querryString;
        }
    }
}
