using EmployeePortalAPI.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData.DeleteData
{
    public interface IDeleteData
    {
        HttpStatusCode DeleAccount(DeleteAccountModel deleteAccountModel);
        HttpStatusCode DeleteCustomer(string customerName);
    }
}