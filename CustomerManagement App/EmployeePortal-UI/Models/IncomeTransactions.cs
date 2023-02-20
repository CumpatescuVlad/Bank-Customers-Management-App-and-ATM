namespace EmployeePortal_UI.Models
{
    public class IncomeTransactions
    {
        public string? TypeOfTransfer { get; set; }
        public string? AccountUsed { get; set; }
        public string? Sender { get; set; }
        public int Amount { get; set; }
        public string? TransactionDate { get; set; }
    }
}
