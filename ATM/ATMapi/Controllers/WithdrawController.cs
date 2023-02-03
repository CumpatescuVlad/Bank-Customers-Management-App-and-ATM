using ATMapi.Filters;
using ATMapi.Modeles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ATMapi.Controllers
{
    
    [ApiController]
    public class WithdrawController : ControllerBase
    {
        [HttpGet]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("API/Withdraw")]

        public IActionResult Withdraw([FromBody] WithdrawModel withdrawModel)
        {
            if (withdrawModel is not null)
            {
                return Ok(withdrawModel);
            }

            return BadRequest();
        }
    }
}
