using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.Services
{
    public interface ICreateDataService
    {
        HttpStatusCode AddNewCustomer(CustomerModel customerModel);
        HttpStatusCode CreateNewAccount(CreateAccountModel createAccountModel);
    }
}