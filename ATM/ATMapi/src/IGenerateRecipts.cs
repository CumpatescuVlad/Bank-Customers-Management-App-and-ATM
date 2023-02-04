using ATMapi.Modeles;

namespace ATMapi.src
{
    public interface IGenerateRecipts
    {
        string GenerateDepositRecipt(string accountIBAN, int amount);
        string GenerateSoldRecipt(string accountNumber, string accountIBAN, int ballance);
        string GenerateWithdrawRecipt(string accountNumber,int amount);
    }
}