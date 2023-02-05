using ATMapi.DataAcces;
using System.Net;

namespace ATMapi.Services
{
    public class DataValidationService : IDataValidationService
    {
        private readonly IReadData _readData;

        public DataValidationService(IReadData readData)
        {
            _readData = readData;
        }

        public HttpStatusCode CustomerExists(string customerFullName)
        {
            var searchCustomerResult = _readData.ReadCustomer(customerFullName);

            return searchCustomerResult;

        }

        public HttpStatusCode CheckBallance(string customerName, string accountNumber, int? ballanceToWithdraw)
        {
            var availabbleBallance = _readData.ReadAccountInfo(customerName, accountNumber);

            if (ballanceToWithdraw <= 0)
            {
                return HttpStatusCode.BadRequest;
            }
            else if (availabbleBallance.Ballance < ballanceToWithdraw)
            {
                return HttpStatusCode.Conflict;
            }

            return HttpStatusCode.OK;
        }

    }
}
