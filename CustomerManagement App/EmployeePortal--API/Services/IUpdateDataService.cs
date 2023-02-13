using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.Services
{
    public interface IUpdateDataService
    {
        HttpStatusCode UpdateCustomer(UpdateDataModel updateDataModel);
    }
}