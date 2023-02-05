using ATMapi.Modeles;
using System.Net;

namespace ATMapi.Services
{
    public interface IDepositService
    {
        HttpStatusCode DepositBallance(DepositModel depositModel);
        string CreateDepositRecipt(string accountIBAN, int amount);
    }
}