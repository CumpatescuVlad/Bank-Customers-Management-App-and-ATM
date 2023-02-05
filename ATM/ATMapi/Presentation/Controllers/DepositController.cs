using ATMapi.BusinessLogic.Filters;
using ATMapi.BusinessLogic.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ATMapi.Presentation.Controllers
{

    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly IDepositService _depositService;
        private readonly IDataValidationService _checkData;
        public DepositController(IDepositService depositService, IDataValidationService checkData)
        {
            _depositService = depositService;
            _checkData = checkData;
        }

        [HttpPost]

        [Route("ATM/Deposit")]

        [ServiceFilter(typeof(ModelFilter))]

        public IActionResult NewDeposit(DepositModel depositmodel)
        {
            var customerExists = _checkData.CustomerExists(depositmodel.AccountOwnerName);

            if (customerExists is HttpStatusCode.NotFound)
            {
                return NotFound("Customer Was Not Found.");

            }
            else if (customerExists is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500, "Server Not Available ,Try Again Later.");
            }

            var depositStatusCode = _depositService.DepositBallance(depositmodel);

            if (depositStatusCode is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500);
            }
            else if (depositStatusCode is HttpStatusCode.NotFound)
            {
                return NotFound();

            }

            return Ok();
        }

        [HttpGet]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("ATM/Deposit/Recipt/{accountIBAN}/{amount}")]

        public IActionResult DepositRecipt(string accountIBAN, int amount)
        {
            string depositRecipt = _depositService.CreateDepositRecipt(accountIBAN, amount);

            if (depositRecipt is not null)
            {
                return Ok(depositRecipt);
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
