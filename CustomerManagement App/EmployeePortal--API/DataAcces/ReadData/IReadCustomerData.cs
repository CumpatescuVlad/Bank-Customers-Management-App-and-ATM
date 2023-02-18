using EmployeePortal__API.BusinessLogic.DTOs;
using Microsoft.Data.SqlClient;

namespace EmployeePortal__API.DataAcces.ReadData
{
    public interface IReadCustomerData
    {
        string ReadCustomer(string customerName);
        CustomerDataDTO ReadCustomerInfo(string customerName);
    }
}