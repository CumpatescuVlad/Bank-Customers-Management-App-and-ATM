using ATM_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Web;

namespace ATM_UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient;

        public LoginController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet]

        [Route("/ATM/Login")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]

        public IActionResult LogIN(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("LoginPage");

            }

            var autorizationStatus = _httpClient.PostAsync("https://localhost:7004/ATM/Authorize", new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json")).Result;

            if (autorizationStatus.StatusCode is HttpStatusCode.Accepted)
            {
                var accountNumber = HttpUtility.UrlEncode(loginModel.AccountNumber);

                return Redirect($"/ATM/Operations/{loginModel.CustomerName}/{accountNumber}");

            }
            else if (autorizationStatus.StatusCode is HttpStatusCode.Forbidden)
            {
                return Redirect($"/LOGIN/Forbidden/{loginModel.CustomerName}/{loginModel.AccountNumber}");

            }
            else if (autorizationStatus.StatusCode is HttpStatusCode.UnprocessableEntity)
            {
                return RedirectToAction("LoginPage");
            }

            return Redirect("/InternalServerError");

        }

        [HttpGet]

        [Route("/LOGIN/Forbidden/{customerName}")]

        public IActionResult Forbidden(string customerName)
        {
            return View(new LoginModel() { CustomerName = customerName });
        }
    }
}
