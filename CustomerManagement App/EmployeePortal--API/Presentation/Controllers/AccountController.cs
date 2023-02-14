using EmployeePortal__API.Services;
using EmployeePortal__API.BusinessLogic.Filters;
using EmployeePortal__API.BusinessLogic.Modeles;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EmployeePortal__API.Presentation.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IInfoService _infoService;
        private readonly ICreateDataService _createDataService;
        private readonly IUpdateDataService _updateDataService;
        private readonly IDeleteDataService _deleteDataService;

        public AccountController(IInfoService infoService, ICreateDataService createDataService, IUpdateDataService updateDataService, IDeleteDataService deleteDataService)
        {
            _infoService= infoService;
            _createDataService= createDataService;
            _updateDataService= updateDataService;
            _deleteDataService= deleteDataService;
            
        }

        [HttpGet]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Accounts/AccountInfo")]

        public IActionResult GetAccountInfo(string customerName)
        {
            var accountResult = _infoService.GetAccountInfo(customerName);

            if (accountResult is null)
            {
                return StatusCode(500);
            }
          
            return Ok(accountResult);

        }

        [HttpGet]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Accounts/Transactions/{customerName}")]

        public IActionResult GetTransactions(string customerName)
        {
            //If You Recive 404 Error Encode account number.

            var  transactionsResult = _infoService.GetAccountTransactions(customerName);

            if (transactionsResult is null) 
            {
                return StatusCode(500);
            }

            return Ok(transactionsResult);
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Account/CreateAccount")]

        public IActionResult CreateAccount(CreateAccountModel createAccountModel)
        {
            var createAccountResult = _createDataService.CreateNewAccount(createAccountModel);

            if (createAccountResult is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500);
            }

            return Created("Portal/Account/CreateAccount", createAccountModel);
        }

        [HttpDelete]
        [ServiceFilter(typeof(ModelValidationFilter))]
        [Route("Portal/Account/DeleteAccount")]

        public IActionResult DeleteAccount(DeleteAccountModel deleteAccountModel)
        {
            var deleteAccountResult = _deleteDataService.DeleteAccount(deleteAccountModel);

            if (deleteAccountResult is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500);
            }

            return Ok(deleteAccountResult);
        }

    }
}
