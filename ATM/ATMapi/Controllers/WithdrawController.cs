using ATMapi.Filters;
using ATMapi.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ATMapi.Controllers
{

    [ApiController]
    public class WithdrawController : ControllerBase
    {
        private readonly IWithdrawService _withdrawService;
        public WithdrawController(IWithdrawService withdrawService)
        {
            _withdrawService = withdrawService;
        }

        [HttpPost]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("API/Withdraw")]

        public IActionResult Withdraw(WithdrawModel withdrawModel)
        {
            var withdrawStatusCode = _withdrawService.WithdrawBallance(withdrawModel);

            if (withdrawStatusCode is HttpStatusCode.Created)
            {
                return Ok();
            }
            else if (withdrawStatusCode is HttpStatusCode.NotFound)
            {
                return NotFound();

            }

            return StatusCode(500);
        }

        [HttpPost]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("API/Withdraw/Recipt")]

        public IActionResult CreateWithdrawRecipt([FromQuery] string accountNumber, int amount)
        {
            string withdrawRecipt = _withdrawService.CreateWithdrawRecipt(accountNumber, amount);

            if (withdrawRecipt is not null)
            {
                return Ok(withdrawRecipt);
            }
            else
            {
                return StatusCode(500);
            }

        }



    }
}
