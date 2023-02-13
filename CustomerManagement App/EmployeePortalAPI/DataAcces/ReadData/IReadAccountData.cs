using EmployeePortalAPI.BusinessLogic.DTOs;
using EmployeePortalAPI.BusinessLogic.Modeles;

namespace EmployeePortalAPI.DataAcces.ReadData
{
    public interface IReadAccountData
    {
        AccountDTO ReadAccountInfo(string customerName);
        TransactionsDTO ReadTransactions(TransactionModel transactionModel);
    }
}