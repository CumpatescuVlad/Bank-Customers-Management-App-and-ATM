using ATMapi.Filters;
using ATMapi.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        public IActionResult NewDeposit(DepositModel depositmodel)
        {
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

        [HttpPost]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("ATM/Deposit/Recipt")]

        public IActionResult DepositRecipt([FromQuery] string accountIBAN, int amount)
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
