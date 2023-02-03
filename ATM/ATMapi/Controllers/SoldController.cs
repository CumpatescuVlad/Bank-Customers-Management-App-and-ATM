using ATMapi.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ATMapi.Controllers
{
    
    [ApiController]
    public class SoldController : ControllerBase
    {
        [HttpGet]

        [ServiceFilter(typeof(ModelFilter))]

        [Route("/ATM/Sold/{customerName}/{accountNumber}")]

        public IActionResult GetSoldInfo()
        {
         //    if (soldDto is not null)
         //    {
         //        return Ok(dto);
         //    }
            
            return NoContent();
        }
    }
}
