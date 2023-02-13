using EmployeePortalAPI.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData.InsertData
{
    public interface IInsertData
    {
        HttpStatusCode InsertBankAccount(CreateAccountModel createAccountModel);
        HttpStatusCode InsertCustomer(CustomerModel customerModel);
    }
}