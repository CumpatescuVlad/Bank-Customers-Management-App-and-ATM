using ATM_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Web;
using System.Net;

namespace ATM_UI.Controllers
{
    public class OperationsController : Controller
    {
        private readonly HttpClient _httpClient;

        public OperationsController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet]

        [Route("ATM/Operations/{customerName}/{accountNumber}")]
        public IActionResult Operations(string customerName, string accountNumber)
        {
            var accountInfo = _httpClient.GetStringAsync($"https://localhost:7004/ATM/Sold/{customerName}/{HttpUtility.UrlEncode(accountNumber)}").Result;

            var soldData = JsonConvert.DeserializeObject<SoldModel>(accountInfo);

            return View(soldData);
        }


        [HttpGet]

        [Route("ATM/Sold")]
        public IActionResult Sold()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Deposit()
        {
            return View();
        
        }

        [HttpGet]

        public IActionResult Withdraw()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DepositBallance(DepositModel depositModel)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Error");
            }

            var depositResult = _httpClient.PostAsync("https://localhost:7004/ATM/Deposit",new StringContent(JsonConvert.SerializeObject(depositModel),Encoding.UTF8, "application/json")).Result;

            if (depositResult.StatusCode is HttpStatusCode.OK)
            {
                return Redirect("/Succes");
               
            }
            else if (depositResult.StatusCode is HttpStatusCode.NotFound)
            {
                return Redirect("/CustomerNotFound");
            }

            return Redirect("/Error");
        }


        [HttpPost]
        public IActionResult WithdrawBallance(WithdrawModel withdrawModel)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Error");
            }

            var withdrawResult = _httpClient.PostAsync("https://localhost:7004/ATM/Withdraw", new StringContent(JsonConvert.SerializeObject(withdrawModel), Encoding.UTF8, "application/json")).Result;

            if (withdrawResult.StatusCode is HttpStatusCode.OK)
            {
                return Redirect("/Succes");
            }
            else if (withdrawResult.StatusCode is HttpStatusCode.NotFound)
            {
                return Redirect("/CustomerNotFound");
            }

            return Redirect("/Error");
        }


    }
}
