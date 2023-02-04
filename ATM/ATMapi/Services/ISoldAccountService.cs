using ATMapi.Modeles;

namespace ATMapi.Services
{
    public interface ISoldAccountService
    {
        string SoldAccount(string customerName, string accountNumber);
        string CreateSoldRecipt(SoldModel soldModel);
    }
}