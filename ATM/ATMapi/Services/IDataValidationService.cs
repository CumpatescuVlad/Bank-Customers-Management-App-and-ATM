using System.Net;

namespace ATMapi.Services
{
    public interface IDataValidationService
    {
        HttpStatusCode CheckBallance(string customerName, string accountNumber, int? ballanceToWithdraw);
        HttpStatusCode CustomerExists(string customerFullName);
    }
}