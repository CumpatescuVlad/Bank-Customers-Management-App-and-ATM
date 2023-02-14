using EmployeePortal__API.DataAcces.ModifyData.UpdateData;
using System.Net;

namespace EmployeePortal__API.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly IUpdateData _updateData;

        public MaintenanceService(IUpdateData updateData)
        {
            _updateData = updateData;
        }

        public HttpStatusCode RegenerateCardPinCode(string customerName)
        {
            var updatePinCodeRespone = _updateData.UpdateCreditCard(customerName);

            if (updatePinCodeRespone is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.OK;
        }
    }
}
