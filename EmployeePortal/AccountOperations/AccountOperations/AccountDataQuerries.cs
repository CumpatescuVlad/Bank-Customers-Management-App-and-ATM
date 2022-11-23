using EmployeeInterface;

namespace AccountOperations
{
    public class AccountDataQuerries
    {
        private readonly GenerateSecurityElements element = new GenerateSecurityElements();

        public string DeleteCreditCardData(string customerName) => $"Delete CreditCard where CustomerName='{customerName}'";

        public string DeleteAccount(string customerName, string accountNumber) => $"Delete Accounts  Where CustomerName ='{customerName}'And AccountNumber ='{accountNumber}'";

        public string ReadAccounts(string customerName) => $"Select  CustomerName,AccountIBAN,AccountNumber,Amount,AccountName  from Accounts Where CustomerName='{customerName}'";

        public string DeleteTransactions(string customerName, string accountNumber) => $"Delete TransactionsTable  Where CustomerName ='{customerName}'And CustomerAccountNo ='{accountNumber}'";

        public string InsertCompany(string companyName, string companyService) => $"Insert into CompaniesAccounts (CompanyName,CompanyServices,CompanyIBAN,Amount) values ('{companyName}','{companyService}','{element.GenerateAccountIBAN()}','0')";

        public string InsertAccount(string customerName, int amount, string accountName) => $"Insert into Accounts (CustomerName,AccountIBAN,AccountNumber,Amount,AccountName) values('{customerName}','{element.GenerateAccountIBAN()}','{element.GenerateAccountNumber()}','{amount}','{accountName}')";

        public string DisplayAccountTransactions(string customerName, string accountNumber) => $"Select CustomerName , CustomerAccountNo ,CustomerIBAN, CustomerAccountName , Amount , Date from TransactionsTable Where CustomerName='{customerName}' And CustomerAccountNo='{accountNumber}' And TransactionType='Withdraw'";

        public string CreateCardData(string IBAN, string customerName) => $"Insert into CreditCard (CustomerName,CreditCardNumber,CreditCardCVV,CrediCardPIN,AccountIBAN,CreditCardExpirationDate) values ('{customerName}','{element.GenerateCardNumber()}','{element.GenerateCVVCode()}','{element.GenerateCardPIN()}','{IBAN}','20/2026')";

        public string DisplayAccountTransactionsOrdered(string customerName, string accountNumber, string order) => $"Select CustomerName , CustomerAccountNo ,CustomerIBAN, CustomerAccountName , Amount , Date from TransactionsTable Where CustomerName='{customerName}' And CustomerAccountNo='{accountNumber}' And TransactionType='Withdraw' Order By {order}";


    }
}
