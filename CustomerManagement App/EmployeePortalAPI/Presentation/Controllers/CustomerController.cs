using EmployeePortalAPI.BusinessLogic.Filters;
using EmployeePortalAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortalAPI.Presentation.Controllers
{
   
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IInfoService _infoService;

        public CustomerController(IInfoService infoService)
        {
            _infoService = infoService;
        }

        [HttpGet]

        [ServiceFilter(typeof(ModelValidationFilter))]

        [Route("Portal/Customer/Info/{customerName}")]

        public IActionResult GetCustomerInfo(string customerName)
        {
            var infoService = _infoService.GetCustomerInfo(customerName);

            if (infoService is null)
            {
                return StatusCode(500);
            }

            return Ok(infoService);
        }
    }
}
