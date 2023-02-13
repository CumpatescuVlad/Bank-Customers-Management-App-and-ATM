using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.DataAcces.ReadData;
using EmployeePortalAPI.DataAcces.ModifyData.InsertData;
using System.Net;

namespace EmployeePortalAPI.Services
{
    public class DataService
    {
        private readonly IReadCustomerData _readCustomerData;
        private readonly IInsertData _insertData;
       
        public DataService(IReadCustomerData readCustomerData,IInsertData insertData)
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
            
           return HttpStatusCode.InternalServerError;
            
        }

    }
}
