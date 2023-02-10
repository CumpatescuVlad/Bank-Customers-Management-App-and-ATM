using ATMapi.BusinessLogic.Filters;
using ATMapi.BusinessLogic.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ATMapi.Presentation.Controllers
{

    [ApiController]
    public class WithdrawController : ControllerBase
    {
        private readonly IWithdrawService _withdrawService;
        private readonly IDataValidationService _checkData;
        public WithdrawController(IWithdrawService withdrawService, IDataValidationService checkData)
        {
            _withdrawService = withdrawService;
            _checkData = checkData;
        }

        [HttpPost]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("ATM/Withdraw")]

        public IActionResult Withdraw(WithdrawModel withdrawModel)
        {
            var customerExists = _checkData.CustomerExists(withdrawModel.AccountOwnerName);

            if (customerExists is HttpStatusCode.NotFound)
            {
                return NotFound("Customer Was Not Found.");
            }
            else if (customerExists is HttpStatusCode.InternalServerError)
            {
                return StatusCode(500, "Server Not Availabble , Try Again Later.");
            }

            var enoughBallance = _checkData.CheckBallance(withdrawModel.AccountOwnerName, withdrawModel.AccountNumber, withdrawModel.Amount);

            if (enoughBallance is HttpStatusCode.BadRequest)
            {
                return BadRequest("Ballance Cannot Be 0 Or Less.");
            }

            else if (enoughBallance is HttpStatusCode.Conflict)
            {
                return Conflict("Not Enough Funds.");
            }

            var withdrawStatusCode = _withdrawService.WithdrawBallance(withdrawModel);

            if (withdrawStatusCode is HttpStatusCode.NotFound)
            {
                return NotFound();

            }
            else if (withdrawStatusCode is HttpStatusCode.InternalServerError)
            {

                return StatusCode(500);
            }

            return Ok();
        }

        [HttpGet]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("API/Withdraw/Recipt/{accountNumber}/{amount}")]

        public IActionResult CreateWithdrawRecipt(string accountNumber, int amount)
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
