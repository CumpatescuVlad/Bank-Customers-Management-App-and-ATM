using ATM.App_functionality;

namespace ATM.Data
{
    public class DataSource
    {
        Temp temp = new Temp();
        private int _attempts = 3;
        public int Attempts { get => _attempts; set => _attempts = value; }

        private string _bankAppConnectionString = @"Server=tcp:vlad07072003.database.windows.net,1433;Initial Catalog=BankApp;Persist Security Info=False;
            User ID=Vlad;Password=Apicultor__69;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;
            Connection Timeout=30;";

        public string ConnectionString { get => _bankAppConnectionString; }

        public string CreditCardInfo(string creditCardNumber) => $"Select CustomerName,CreditCardNumber,CrediCardPIN,AccountIBAN from CreditCard where CreditCardNumber='{creditCardNumber}'";

        public string ReadAccountAmount(string IBAN) => $"Select Amount from Accounts where AccountIBAN='{IBAN}'";

        public string UpdateAmount(string IBAN, int amount) => $"Update Accounts   set Amount='{amount}' where AccountIBAN='{IBAN}'";

        public string InsertTransactionRecord(string IBAN, int amount, string transactionType) => $"Insert into TransactionsTable (CustomerName,CustomerAccountNo,CustomerIBAN,CustomerAccountName,Amount,Date,TransactionType) values ('{temp.ReadFile("CustomerName.txt")}','{temp.ReadFile("AccountNumber.txt")}','{IBAN}','{temp.ReadFile("AccountName.txt")}','{amount}','{DateTime.Now}','{transactionType}')";

        public string ReadCustomerAccountData(string IBAN) => $"Select  AccountNumber ,AccountName from Accounts  where AccountIBAN='{temp.ReadFile("AccountIBAN.txt")}'";


    }
}
