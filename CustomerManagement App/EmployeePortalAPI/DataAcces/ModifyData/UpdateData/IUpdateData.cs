using EmployeePortalAPI.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortalAPI.DataAcces.ModifyData.UpdateData
{
    public interface IUpdateData
    {
        HttpStatusCode UpdateCustomerData(UpdateDataModel updateModel);
    }
}