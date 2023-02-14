using EmployeePortal__API.BusinessLogic.DTOs.TransactionsDTOs;

namespace EmployeePortal__API.BusinessLogic.DTOs
{
    public class TransactionsDTO
    {
        public TransactionsDTO(List<ATMTransactionsDTO>? atmTransactions, List<IncomeTransactionsDTO>? incomeTransactions, List<OutcomeTransactionsDTO>? outcomeTransactions)
        {
            AtmTransactions = atmTransactions;
            IncomeTransactions = incomeTransactions;
            OutcomeTransactions = outcomeTransactions;
        }

       public List<ATMTransactionsDTO>? AtmTransactions { get;set; }
       public List<IncomeTransactionsDTO>? IncomeTransactions { get;set; }
       public List<OutcomeTransactionsDTO>? OutcomeTransactions { get;set; }

    }
}
