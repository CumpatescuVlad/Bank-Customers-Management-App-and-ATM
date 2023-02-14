namespace EmployeePortal__API.BusinessLogic.DTOs.TransactionsDTOs
{
    public class OutcomeTransactionsDTO
    {
        public OutcomeTransactionsDTO(string? typeOfTransfer, string? accountUsed, string? recipient, int amount, string? transactionDate)
        {
           
            TypeOfTransfer = typeOfTransfer;
            AccountUsed = accountUsed;
            Recipient = recipient;
            Amount = amount;
            TransactionDate = transactionDate;
        }

        public string? TypeOfTransfer { get; set; }
        public string? AccountUsed { get; set; }
        public string? Recipient { get; set; }
        public int Amount { get; set; }
        public string? TransactionDate { get; set; }
    }
}
