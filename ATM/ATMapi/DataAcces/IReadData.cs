using ATMapi.DTOs;
using ATMapi.Modeles;

namespace ATMapi.DataAcces
{
    public interface IReadData
    {
        SoldDTO ReadAccountInfo(string customerName,string accountNumber);
    }
}