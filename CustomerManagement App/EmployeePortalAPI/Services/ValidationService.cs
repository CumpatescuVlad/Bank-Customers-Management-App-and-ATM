using EmployeePortalAPI.DataAcces;
using System.Net;

namespace EmployeePortalAPI.Services
{
    public class ValidationService : IValidationService
    {
        private readonly IReadData _readData;

        public ValidationService(IReadData readData)
        {
            _readData = readData;
        }

        public HttpStatusCode CheckIfCustomerExists(string customerName)
        {
            string customer = _readData.ReadCustomer(customerName);

            if (String.IsNullOrEmpty(customer))
            {
                return HttpStatusCode.NoContent;
            }
            else if (customer == "Error")
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.BadRequest;
        }
    }
}
