using EmployeePortal__API.BusinessLogic.DTOs;
using EmployeePortal__API.BusinessLogic.Modeles;

namespace EmployeePortal__API.DataAcces.ReadData
{
    public interface IReadAccountData
    {
        AccountDTO ReadAccountInfo(string customerName);
        List<TransactionsDTO> ReadTransactions(TransactionModel transactionModel);
    }
}