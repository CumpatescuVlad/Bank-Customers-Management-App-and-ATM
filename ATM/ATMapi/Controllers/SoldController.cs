using ATMapi.Filters;
using ATMapi.Modeles;
using ATMapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ATMapi.Controllers
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

        [HttpPost]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("/ATM/Recipt/Sold")]

        public IActionResult SoldRecipt(SoldModel soldModel)
        {
            string accountInfo = _soldService.CreateSoldRecipt(soldModel);

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
