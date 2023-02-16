using EmployeePortal__API.BusinessLogic.Filters;
using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.Services;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal__API.Presentation.Controllers
{
    
    [ApiController]
    public class FunctionsController : ControllerBase
    {
        private readonly IUpdateDataService _updateService;
        private readonly IFunctionsService _functionsService;

        public FunctionsController(IFunctionsService functionsService,IUpdateDataService updateData)
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
       
        public IActionResult CreateStatement(StatementModel statementModel)
        {
            var statementCreationResult = _functionsService.CreateStatement(statementModel);

            if (statementCreationResult is HttpStatusCode.Created)
            {
                return File(_functionsService.GetStatement(), "word/doc", "Statement.doc");
            }

            return StatusCode(500);
        }


    }
}
