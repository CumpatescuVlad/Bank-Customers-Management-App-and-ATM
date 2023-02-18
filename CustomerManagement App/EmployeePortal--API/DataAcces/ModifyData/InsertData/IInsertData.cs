using EmployeePortal__API.BusinessLogic.Modeles;
using Microsoft.Data.SqlClient;
using System.Net;

namespace EmployeePortal__API.DataAcces.ModifyData.InsertData
{
    public interface IInsertData
    {
        HttpStatusCode InsertBankAccount(CreateAccountModel createAccountModel);
        HttpStatusCode InsertCustomer(CustomerModel customerModel);
    }
}