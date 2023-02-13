using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.DataAcces.ModifyData.DeleteData
{
    public interface IDeleteData
    {
        HttpStatusCode DeleAccount(DeleteAccountModel deleteAccountModel);
        HttpStatusCode DeleteCustomer(string customerName);
    }
}