using EmployeePortal__API.BusinessLogic.Filters;
using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EmployeePortal__API.Presentation.Controllers
{

    [ApiController]
    public class FunctionsController : ControllerBase
    {
        private readonly IUpdateDataService _updateService;
        private readonly IFunctionsService _functionsService;

        public FunctionsController(IFunctionsService functionsService, IUpdateDataService updateData)
        {
            _functionsService = functionsService;
            _updateService = updateData;
        }

        [HttpPut]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/CreditCard/RegeneratePinCode")]
        public IActionResult RegenerateCreditCardPinCode(string customerName)
        {
            var updateServiceResult = _updateService.UpdateCardPinCode(customerName);

            if (updateServiceResult is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500);
            }

            return Ok();
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Statements")]

        public HttpStatusCode CreateStatement(StatementModel statementModel)
        {
            var statementCreationResult = _functionsService.CreateStatement(statementModel);

            if (statementCreationResult is HttpStatusCode.Created)
            {
                return HttpStatusCode.Created;
            }

            return HttpStatusCode.InternalServerError;
        }


    }
}
