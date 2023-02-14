using System.Net;

namespace EmployeePortal__API.Services
{
    public interface IMaintenanceService
    {
        HttpStatusCode RegenerateCardPinCode(string customerName);
    }
}