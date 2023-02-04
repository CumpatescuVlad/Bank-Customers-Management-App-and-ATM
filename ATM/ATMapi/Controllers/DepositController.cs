using ATMapi.Filters;
using ATMapi.Modeles;
using ATMapi.Services;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ATMapi.Controllers
{

    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly IDepositService _depositService;
        public DepositController(IDepositService depositService)
        {
            _depositService = depositService;
        }

        [HttpPost]

        [Route("ATM/Deposit")]

        [ServiceFilter(typeof(ModelFilter))]

        public IActionResult NewDeposit(TransactionModel transactionModel)
        {
            var depositStatusCode =  _depositService.DepositBallance(transactionModel);

            if (depositStatusCode is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500);
            }
            else if(depositStatusCode is HttpStatusCode.NotFound)
            {
                return NotFound();

            }

            return Ok();
        }

        [HttpPost]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("ATM/Deposit/Recipt")]

        public IActionResult DepositRecipt([FromQuery]string accountIBAN,int amount)
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
