using EmployeePortal__API.BusinessLogic.Filters;
using EmployeePortal__API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal__API.Presentation.Controllers
{
    
    [ApiController]
    public class MaintainanceController : ControllerBase
    {
        private readonly IMaintenanceService _maintenanceService;

        public MaintainanceController(IMaintenanceService maintainanceService)
        {
            _maintenanceService = maintainanceService;
        } 

        [HttpGet]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/CreditCard/PinCodeRegen/{customerName}")]
        public IActionResult CreditCard(string customerName)
        {
            var maintaneServiceResult = _maintenanceService.RegenerateCardPinCode(customerName);

            if (maintaneServiceResult is System.Net.HttpStatusCode.InternalServerError)
            {
                return StatusCode(500);
            }

            return Ok();
        }
    }
}
