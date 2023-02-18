using EmployeePortal__API.BusinessLogic.Modeles;

namespace EmployeePortal__API.Persistence
{
    public class QuerryStrings
    {
        public static string Update(UpdateDataModel update) => $"Update Customers Set {update.ColumnName} ='{update.Value}'  Where CustomerName='{update.OldCustomerName}'";
        public static string UpdatePinCode(string customerName) => $"Update CreditCard Set PinCode ='{GenerateSecurityElements.GenerateElement("CardPIN")}' Where CustomerName='{customerName}'";
        public static string Delete(string customerName, string tableToDelete) => $"Delete {tableToDelete} Where CustomerName ='{customerName}'";
        public static string Insert(CustomerModel customerModel, string tableToInsert)
        {
            string insertQuerry = tableToInsert switch
            {
                "Customers" => $"Insert Into Customers (CustomerName,CustomerPhoneNumber,CustomerEmail) Values ('{customerModel.CustomerName}','{customerModel.CustomerPhoneNumber}','{customerModel.CustomerEmail}')",
                "PersonalAccounts" => $"Insert Into PersonalAccounts(CustomerName,AccountName,AccountNumber,AccountIBAN,Ballance) Values ('{customerModel.CustomerName}','{customerModel.AccountName}','{GenerateSecurityElements.GenerateElement("AccountNumber")}','{GenerateSecurityElements.GenerateElement("IBAN")}','{0}')",
                "CreditCard" => $"Insert Into CreditCard (CustomerName,CardNumber,AccountInUse,SecurityCode,PinCode) Values ('{customerModel.CustomerName}','{GenerateSecurityElements.GenerateElement("CardNumber")}',Select AccountIBAN From PersonalAccounts Where CustomerName='{customerModel.CustomerName}','{GenerateSecurityElements.GenerateElement("SecurityCode")}','{GenerateSecurityElements.GenerateElement("CardPIN")}')",
                "BankingApp" => $"Insert Into BankingApp (CustomerName,AppPinCode,AppPassword) Values ('{customerModel.CustomerName}','{GenerateSecurityElements.GenerateElement("Password")}','{GenerateSecurityElements.GenerateElement("AppPin")}')",
                _ => "No Relevant Info Provided",
            };
            return insertQuerry;

        }

        public static string Select(string customerName, string itemsToSelect)
        {
            string selectQuerry = itemsToSelect switch
            {
                "CustomerName" => $"Select CustomerName From Customers Where CustomerName='{customerName}'",
                "CustomerData" => $"Select CustomerName,CustomerPhoneNumber,CustomerEmail From Customers Where CustomerName='{customerName}'",
                "AccountData" => $"Select CustomerName,AccountName,AccountNumber,AccountIBAN,Ballance From PersonalAccounts Where CustomerName='{customerName}'",
                _ => "No Relevant Items Provded",
            };
            return selectQuerry;
        }

        public static string SelectTransactions(string customerName, string tableToSelect)
        {
            string selectString = tableToSelect switch
            {
                "ATMTransactions" => $"Select TypeOfTransactions,AccountUsed,TransactionDate From ATMTransactions Where CustomerName='{customerName}'",
                "IncomingTransfers" => $"Select AccountUsed,Sender,Amount,TransactionDate From IncomingTransfers Where CustomerName='{customerName}' AND TypeOfTransfer = 'Income'",
                "OutcomingTransfer" => $"Select AccountUsed,Recipient,Amount,TransactionDate From OutcomingTransfers Where CustomerName='{customerName}' AND TypeOfTransfer = 'Outcome'",
                _ => "No Relevant Info Was Provided",
            };

            return selectString;

        }

        public static string InsertAccount(CreateAccountModel accountModel)
        {
            string querryString;

            if (accountModel.TypeOfAccount == "PersonalAccount")
            {
                querryString = $"Insert Into PersonalAccountsTable (CustomerName,AccountName,AccountNumber,AccountIBAN,Ballance) Values ('{accountModel.CustomerName}','{accountModel.AccountName}','{GenerateSecurityElements.GenerateElement("AccountNumber")}','{GenerateSecurityElements.GenerateElement("IBAN")}','{accountModel.Ballance}')";
            }
            else
            {
                querryString = $"Insert Into BusinessAccountsTable (CustomerName,AccountName,AccountNumber,AccountIBAN,Amount) Values ('{accountModel.CustomerName}','{accountModel.AccountName}','{GenerateSecurityElements.GenerateElement("AccountNumber")}','{GenerateSecurityElements.GenerateElement("IBAN")}','{0}')";
            }
            return querryString;
        }

        public static string DeleteAccount(DeleteAccountModel deleteAccountModel)
        {
            string querryString;

            if (deleteAccountModel.TypeOfAccount == "PersonalAccount")
            {
                querryString = $"Delete PersonalAccountsTable Where CustomerName='{deleteAccountModel.CustomerName}' AND AccountName='{deleteAccountModel.AccountName}'";
            }
            else
            {
                querryString = $"Delete BusinessAccountsTable Where CustomerName='{deleteAccountModel.CustomerName}' AND AccountName='{deleteAccountModel.AccountName}'";
            }

            return querryString;
        }

    }
}
