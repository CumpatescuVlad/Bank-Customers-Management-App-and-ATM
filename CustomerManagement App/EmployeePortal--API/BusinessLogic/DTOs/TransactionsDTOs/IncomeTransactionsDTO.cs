namespace EmployeePortal__API.BusinessLogic.DTOs.TransactionsDTOs
{
    public class IncomeTransactionsDTO
    {
        public IncomeTransactionsDTO(string? typeOfTransfer, string? accountUsed, string? sender, int amount, string? transactionDate)
        {
            TypeOfTransfer = typeOfTransfer;
            AccountUsed = accountUsed;
            Sender = sender;
            Amount = amount;
            TransactionDate = transactionDate;
        }

        public string? TypeOfTransfer { get; set; }
        public string? AccountUsed { get; set; }
        public string? Sender { get; set; }
        public int Amount { get; set; }
        public string? TransactionDate { get; set; }
    }
}
