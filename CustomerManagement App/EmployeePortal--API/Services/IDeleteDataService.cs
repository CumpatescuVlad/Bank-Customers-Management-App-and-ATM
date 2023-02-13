using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.Services
{
    public interface IDeleteDataService
    {
        HttpStatusCode DeleteAccount(DeleteAccountModel deleteAccountModel);
        HttpStatusCode DeleteCustomer(string customerName);
    }
}