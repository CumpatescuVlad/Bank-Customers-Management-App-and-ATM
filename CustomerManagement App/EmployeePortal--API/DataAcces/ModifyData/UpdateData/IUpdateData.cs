using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.DataAcces.ModifyData.UpdateData
{
    public interface IUpdateData
    {
        HttpStatusCode UpdateCustomerData(UpdateDataModel updateModel);
        HttpStatusCode UpdateCreditCard(string customerName);
    }
}