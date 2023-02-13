using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.DataAcces.ModifyData.DeleteData;
using System.Net;

namespace EmployeePortal__API.Services
{
    public class DeleteDataService : IDeleteDataService
    {
        private readonly IDeleteData _deleteData;

        public DeleteDataService(IDeleteData deleteData)
        {
            _deleteData = deleteData;
        }

        public HttpStatusCode DeleteCustomer(string customerName)
        {
            var deleteCustomerResult = _deleteData.DeleteCustomer(customerName);

            if (deleteCustomerResult is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.OK;
        }

        public HttpStatusCode DeleteAccount(DeleteAccountModel deleteAccountModel)
        {
            var deleteAccountResult = _deleteData.DeleAccount(deleteAccountModel);

            if (deleteAccountResult is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.OK;
        }

    }
}
