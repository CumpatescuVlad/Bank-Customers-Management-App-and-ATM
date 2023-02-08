using ATMapi.BusinessLogic.Modeles;
using ATMapi.DataAcces;
using System.Net;

namespace ATMapi.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IReadData _readData;

        public AuthorizationService(IReadData readData)
        {
            _readData = readData;

        }

        public HttpStatusCode AuthorizeService(AuthorizationModel authorizationModel)
        {
            var atmPin = _readData.ReadCustomerATMPin(authorizationModel.CustomerName);

            if (atmPin.ATMPin == authorizationModel.Pin)
            {
                return HttpStatusCode.Accepted;
            }
            else if (atmPin.ATMPin == 0)
            {
                return HttpStatusCode.NotFound;
            }
            else if (atmPin.ATMPin != authorizationModel.Pin)
            {
                return HttpStatusCode.Forbidden;
            }


            return HttpStatusCode.InternalServerError;
        }

    }
}
