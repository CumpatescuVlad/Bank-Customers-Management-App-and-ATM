using ATMapi.BusinessLogic.Filters;
using ATMapi.BusinessLogic.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ATMapi.Presentation.Controllers
{

    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        public AuthorizationController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        [HttpPost]

        [Route("/ATM/Authorize")]

        [ServiceFilter(typeof(ModelFilter))]
        public IActionResult Authorize(AuthorizationModel authorizationModel)
        {
            var authorizationStatus = _authorizationService.AuthorizeService(authorizationModel);

            if (authorizationStatus is HttpStatusCode.Accepted)
            {
                return Accepted($"User {authorizationModel.CustomerName} is accepted.");
            }
            else if (authorizationStatus is HttpStatusCode.Forbidden)
            {
                return Problem(
                    type: "/docs/errors/forbidden",
                    title: $"User {authorizationModel.CustomerName} is not authorized.",
                    detail: $"User '{authorizationModel.CustomerName}' entered Wrong PIN!",
                    statusCode: StatusCodes.Status403Forbidden,
                    instance: HttpContext.Request.Path
                    );
            }
            else if (authorizationStatus is HttpStatusCode.NotFound)
            {
                return NotFound($"User {authorizationModel.CustomerName} was not found.");
            }


            return StatusCode(500);

        }
    }
}
