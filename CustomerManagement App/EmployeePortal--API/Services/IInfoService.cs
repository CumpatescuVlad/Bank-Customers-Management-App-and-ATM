using EmployeePortal__API.BusinessLogic.Modeles;

namespace EmployeePortal__API.Services
{
    public interface IInfoService
    {
        string GetAccountInfo(string customerName);
        string GetAccountTransactions(TransactionModel transactionModel);
        string GetCustomerInfo(string customerName);
    }
}