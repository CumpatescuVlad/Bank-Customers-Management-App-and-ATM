using ATMapi.BusinessLogic.Filters;
using ATMapi.BusinessLogic.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ATMapi.Presentation.Controllers
{
    [ApiController]
    public class SoldController : ControllerBase
    {
        private readonly ISoldAccountService _soldService;

        public SoldController(ISoldAccountService soldService)
        {
            _soldService = soldService;
        }

        [HttpGet]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("/ATM/Sold/{customerName}/{accountNumber}")]

        public IActionResult GetSoldInfo(string customerName, string accountNumber)
        {
            var accountInfo = _soldService.SoldAccount(customerName, accountNumber);

            if (accountInfo is not null)
            {
                return Ok(accountInfo);

            }
            else
            {
                return StatusCode(500);
            }

        }

        [HttpGet]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("/ATM/Recipt/Sold/{accountNumber}/{accountIBAN}/{ballance}")]

        public IActionResult SoldRecipt(string accountNumber,string accountIBAN,int ballance)
        {
            string accountInfo = _soldService.CreateSoldRecipt(accountNumber,accountIBAN,ballance);

            if (accountInfo is not null)
            {
                return Ok(accountInfo);
            }
            else
            {
                return StatusCode(500);
            }

        }

    }
}
