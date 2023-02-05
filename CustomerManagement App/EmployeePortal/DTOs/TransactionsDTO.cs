namespace EmployeePortal.DTOs
{
    public class TransactionsDTO
    {
        public TransactionsDTO(string accountOwnerName, string accountNumber, string accountIBAN, string accountName, int amount, string date)
        {
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            AccountIBAN = accountIBAN;
            AccountName = accountName;
            Amount = amount;
            Date = date;
        }

        public string AccountOwnerName { get; private set; }
        public string AccountNumber { get; private set; }
        public string AccountIBAN { get; private set; }
        public string AccountName { get; private set; }
        public int Amount { get; private set; }
        public string Date { get; private set; }

    }
}
