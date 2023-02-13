namespace EmployeePortal__API.BusinessLogic.DTOs
{
    public class TransactionsDTO
    {
        public TransactionsDTO(string accountOwnerName, string typeOfTransaction, string accountIBAN, int amount, string recipient, string date)
        {
            AccountOwnerName = accountOwnerName;
            TypeOfTransaction = typeOfTransaction;
            AccountIBAN = accountIBAN;
            Amount = amount;
            Recipient = recipient;
            Date = date;
        }

        public string AccountOwnerName { get; private set; }
        public string TypeOfTransaction { get; private set; }
        public string AccountIBAN { get; private set; }
        public int Amount { get; private set; }
        public string Recipient { get; private set; }
        public string Date { get; private set; }

    }
}
