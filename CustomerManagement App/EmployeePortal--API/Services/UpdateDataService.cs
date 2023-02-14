using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.DataAcces.ModifyData.UpdateData;
using System.Net;

namespace EmployeePortal__API.Services
{
    public class UpdateDataService : IUpdateDataService
    {
        private readonly IUpdateData _updateData;

        public UpdateDataService(IUpdateData updateData)
        {
            _updateData = updateData;
        }

        public HttpStatusCode UpdateCustomer(UpdateDataModel updateDataModel)
        {
            var updateDataResult = _updateData.UpdateCustomerData(updateDataModel);

            if (updateDataResult is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.OK;
        }

        public HttpStatusCode UpdateCardPinCode(string customerName)
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
