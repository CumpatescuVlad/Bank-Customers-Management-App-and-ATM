using EmployeePortalAPI.BusinessLogic.DTOs;

namespace EmployeePortalAPI.DataAcces.ReadData
{
    public interface IReadCustomerData
    {
        string ReadCustomer(string customerName);
        CustomerDataDTO ReadCustomerInfo(string customerName);
    }
}