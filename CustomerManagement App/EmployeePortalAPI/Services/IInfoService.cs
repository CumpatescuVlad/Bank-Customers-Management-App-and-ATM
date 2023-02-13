using EmployeePortalAPI.BusinessLogic.Modeles;

namespace EmployeePortalAPI.Services
{
    public interface IInfoService
    {
        string GetAccountInfo(string customerName);
        string GetAccountTransactions(TransactionModel transactionModel);
        string GetCustomerInfo(string customerName);
    }
}