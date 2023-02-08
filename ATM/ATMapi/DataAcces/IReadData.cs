using ATMapi.BusinessLogic.DTOs;
using System.Net;

namespace ATMapi.DataAcces
{
    public interface IReadData
    {
        SoldDTO ReadAccountInfo(string customerName, string accountNumber);
        HttpStatusCode ReadCustomer(string customerName);
        PinDTO ReadCustomerATMPin(string customerName);
    }
}