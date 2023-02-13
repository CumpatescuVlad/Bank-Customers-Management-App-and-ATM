using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.BusinessLogic.Filters;
using EmployeePortal__API.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortalAPI.Presentation.Controllers
{

    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IInfoService _infoService;
        private readonly ICreateDataService _createDataService;
        private readonly IDeleteDataService _deleteDataService;
        private readonly IUpdateDataService _updateDataService;
        public CustomerController(IInfoService infoService, ICreateDataService createDataService,IDeleteDataService deleteDataService,IUpdateDataService updateDataService)
        {
            _infoService = infoService;
            _createDataService = createDataService;
            _deleteDataService = deleteDataService;
            _updateDataService = updateDataService;
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

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Customer/AddNewCustomer")]

        public IActionResult AddCustomer(CustomerModel customerModel)
        {
           var addCustomerStatus = _createDataService.AddNewCustomer(customerModel);

           return StatusCode(Convert.ToInt32(addCustomerStatus));

        }

        [HttpDelete]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Customer/DeleteCustomer")]

        public IActionResult DeleteCustomer(string customerName)
        {
            var deleteCustomerResult = _deleteDataService.DeleteCustomer(customerName);

            return StatusCode(Convert.ToInt32(deleteCustomerResult));
        }

        [HttpPut]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Update/UpdateCustomerData")]

        public IActionResult UpdateCustomer(UpdateDataModel updateModel)
        {
            var updateCustomerResult = _updateDataService.UpdateCustomer(updateModel);

            return StatusCode(Convert.ToInt32(updateCustomerResult));

        }

    }
}
