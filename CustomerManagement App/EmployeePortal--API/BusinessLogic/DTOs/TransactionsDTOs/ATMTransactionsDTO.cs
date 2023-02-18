namespace EmployeePortal__API.BusinessLogic.DTOs.TransactionsDTOs
{
    public class ATMTransactionsDTO
    {
        public ATMTransactionsDTO(string? typeOfTransaction, string? accountUsed, int amount, string? transactionDate)
        {
            TypeOfTransaction = typeOfTransaction;
            AccountUsed = accountUsed;
            Amount = amount;
            TransactionDate = transactionDate;
        }

        public string? TypeOfTransaction { get; set; }
        public string? AccountUsed { get; set; }
        public int Amount { get; set; }
        public string? TransactionDate { get; set; }
    }
}
