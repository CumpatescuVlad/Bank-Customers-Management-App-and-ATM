using ATMapi.Modeles;
using System.Net;

namespace ATMapi.Services
{
    public interface IDepositService
    {
        HttpStatusCode DepositBallance(TransactionModel transactionModel);
        string CreateDepositRecipt(string accountIBAN,int amount);
    }
}