using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.DataAcces.ModifyData.InsertData;
using EmployeePortal__API.DataAcces.ReadData;
using System.Net;

namespace EmployeePortal__API.Services
{
    public class CreateDataService : ICreateDataService
    {
        private readonly IReadCustomerData _readCustomerData;
        private readonly IInsertData _insertData;

        public CreateDataService(IReadCustomerData readCustomerData, IInsertData insertData)
        {
            _readCustomerData = readCustomerData;
            _insertData = insertData;

        }

        public HttpStatusCode AddNewCustomer(CustomerModel customerModel)
        {
            var customerExists = _readCustomerData.ReadCustomer(customerModel.CustomerName);

            if (String.IsNullOrEmpty(customerExists))
            {
                var addCustomer = _insertData.InsertCustomer(customerModel);

                if (addCustomer is HttpStatusCode.Created)
                {
                    return HttpStatusCode.Created;
                }
                else if (addCustomer is HttpStatusCode.InternalServerError)
                {
                    return HttpStatusCode.InternalServerError;
                }

            }
            else if (customerExists == "Error")
            {

                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.Conflict;

        }

        public HttpStatusCode CreateNewAccount(CreateAccountModel createAccount)
        {
            var createAccountResult = _insertData.InsertBankAccount(createAccount);

            if (createAccountResult is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.Created;

        }

    }
}
