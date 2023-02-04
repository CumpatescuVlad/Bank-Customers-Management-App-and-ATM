using ATMapi.DTOs;

namespace ATMapi.DataAcces
{
    public interface IReadData
    {
        SoldDTO ReadAccountInfo(string customerName, string accountNumber);
    }
}