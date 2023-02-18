using EmployeePortal__API.BusinessLogic.DTOs;

namespace EmployeePortal__API.DataAcces.ReadData
{
    public interface IReadAccountData
    {
        List<AccountDTO> ReadAccountInfo(string customerName);
        TransactionsDTO ReadTransactions(string customerName);
    }
}