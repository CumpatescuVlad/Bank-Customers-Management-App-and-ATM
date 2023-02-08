using ATM_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATM_UI.Controllers
{
    public class OperationsController : Controller
    {
        [HttpGet]

        [Route("ATM/Operations")]
        public IActionResult Operations()
        {
            return View();
        }


        [HttpGet]

        [Route("ATM/Sold/{customerName}")]
        public IActionResult Sold(string customerName)
        {
            return View();
        }

        [HttpGet]

        //[Route("ATM/Deposit")]
        public IActionResult Deposit()
        {
            return View();
        }

        [HttpPost]

        public IActionResult DepositBallance(DepositModel depositModel)
        {
            return Redirect("/ATM/Operations");
        }

        [HttpGet]

        [Route("ATM/Withdraw")]
        public IActionResult Withdraw()
        {
            return View();
        }

        [HttpPost]

        public IActionResult WithdrawBallance(DepositModel depositModel)
        {
            return Redirect("/ATM/Operations");
        }


    }
}
