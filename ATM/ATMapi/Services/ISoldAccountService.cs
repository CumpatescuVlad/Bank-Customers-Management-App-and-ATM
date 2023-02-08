namespace ATMapi.Services
{
    public interface ISoldAccountService
    {
        string SoldAccount(string customerName, string accountNumber);
        string CreateSoldRecipt(string accountNumber, string accountIBAN, int ballance);
    }
}