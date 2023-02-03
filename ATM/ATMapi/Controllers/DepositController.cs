using ATMapi.Filters;
using ATMapi.Modeles;
using Microsoft.AspNetCore.Mvc;

namespace ATMapi.Controllers
{
    
    [ApiController]
    public class DepositController : ControllerBase
    {
        [HttpPost]

        [Route("ATM/Deposit")]

        [ServiceFilter(typeof(ModelFilter))]

        public IActionResult NewDeposit(DepositModel depositModel)
        {
            //if (depositModel is HttpClient 200 ok )
            //{
            //    return Ok(depositModel);
            //}
            //else
            //{
            //    return BadRequest();
            //}

            return Ok(depositModel);
        }
    }
}
