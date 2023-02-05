using ATMapi.BusinessLogic.Modeles;
using System.Net;

namespace ATMapi.Services
{
    public interface IWithdrawService
    {
        string CreateWithdrawRecipt(string accountNumber, int amount);
        HttpStatusCode WithdrawBallance(WithdrawModel withdrawModel);
    }
}