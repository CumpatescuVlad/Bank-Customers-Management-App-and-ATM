using EmployeePortal__API.BusinessLogic.Modeles;

namespace EmployeePortal__API.Persistence
{
    public class QuerryStrings
    {
        public static string Insert(CustomerModel customer) => $"Insert Into Customer (CustomerFullName,CustomerPassword,CustomerPhoneNumber,CustomerEmail,CustomerPin) Values ('{customer.CustomerName}','{GenerateSecurityElements.GenerateElement("Password")}','{customer.CustomerPhoneNumber}','{customer.CustomerEmail}','{GenerateSecurityElements.GenerateElement("AppPin")}')";
        public static string SelectCustomer(string customerName) => $"Select CustomerFullName From Customer Where CustomerFullName='{customerName}'";
        public static string SelectCustomerData(string customerName) => $"Select CustomerFullName,CustomerPhoneNumber,CustomerEmail From Customer Where CustomerFullName='{customerName}'";
        public static string SelectTransactions(TransactionModel transactionModel) => $"Select CustomerFullName , TypeOfTransaction ,AccountUsed,Amount,Recipient, TransactionDate From Transactions Where CustomerFullName='{transactionModel.AccountOwnerName}' Order By {transactionModel.Order}";

        public static string InsertAccount(CreateAccountModel accountModel)
        {
            string querryString;

            if (accountModel.TypeOfAccount == "PersonalAccount")
            {
                querryString = $"Insert Into PersonalAccountsTable (CustomerName,AccountName,AccountNumber,AccountIBAN,Ballance) Values ('{accountModel.AccountOwnerName}','{accountModel.AccountName}','{accountModel.AccountNumber}','{accountModel.AccountIBAN}','{accountModel.Ballance}')";
            }
            else
            {
                querryString = $"Insert Into BusinessAccountsTable (CustomerName,AccountName,AccountNumber,AccountIBAN,Amount) Values ('{accountModel.AccountOwnerName}','{accountModel.AccountName}','{accountModel.AccountNumber}','{accountModel.AccountIBAN}','{accountModel.Ballance}')";
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
                querryString = $"Delete BusinessAccountsTable Where CustomerName='{deleteAccountModel.AccountOwnerName}' AND AccountName='{deleteAccountModel.AccountName}' AND AccountNumber ='{deleteAccountModel.AccountNumber}'";
            }

            return querryString;
        }
        public static string ReadAccount(string customerName) => $"Select CustomerFullName,AccountIBAN,AccountNumber,Amount,AccountName  From Accounts Where CustomerFullName='{customerName}'";

        public static string DeleteTransactions(DeleteAccountModel deleteAccountModel) => $"Delete Transactions Where CustomerFullName='{deleteAccountModel.AccountOwnerName}'  AND AccountUsed ='{deleteAccountModel.AccountIBAN}'";

        public static string Update(UpdateDataModel update) => $"Update Customer Set {update.ColumnName} ='{update.Value}'  Where CustomerFullName='{update.OldCustomerName}'";

        public static string Delete(string customerName, string tableToDelete)
        {
            string querryString;

            if (tableToDelete == "Customer")
            {
                querryString = $"Delete Customer Where  CustomerFullName ='{customerName}'";
            }
            else if (tableToDelete == "Accounts")
            {
                querryString = $"Delete  Accounts Where  CustomerFullName ='{customerName}'";
            }
            else
            {
                querryString = $"Delete Transactions  Where  CustomerFullName ='{customerName}'";
            }
            return querryString;
        }
    }
}
