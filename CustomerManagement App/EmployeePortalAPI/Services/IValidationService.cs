using System.Net;

namespace EmployeePortalAPI.Services
{
    public interface IValidationService
    {
        HttpStatusCode CheckIfCustomerExists(string customerName);
    }
}