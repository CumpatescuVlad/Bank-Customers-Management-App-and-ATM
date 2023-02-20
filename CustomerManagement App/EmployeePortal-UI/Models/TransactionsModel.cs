namespace EmployeePortal_UI.Models
{
    public class TransactionsModel
    {
        public List<ATMTransactions>? AtmTransactions { get; set; }
        public List<IncomeTransactions>? IncomeTransactions { get; set; }
        public List<OutcomeTransactions>? OutcomeTransactions { get; set; }
    }
}
