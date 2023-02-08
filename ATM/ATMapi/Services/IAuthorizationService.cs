using ATMapi.BusinessLogic.Modeles;
using System.Net;

namespace ATMapi.Services
{
    public interface IAuthorizationService
    {
        HttpStatusCode AuthorizeService(AuthorizationModel authorizationModel);
    }
}