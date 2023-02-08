using ATM_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATM_UI.Controllers
{
    public class LoginController : Controller
    {
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

            else if (loginModel.CustomerPIN != 1234)
            {
                return Redirect($"/LOGIN/Forbidden/{loginModel.CustomerName}/{loginModel.CustomerPIN}");
            }

            return Redirect($"/ATM/Operations");

        }

        [HttpGet]

        [Route("/LOGIN/Forbidden/{customerName}/{customerPIN}")]

        public IActionResult Forbidden(string customerName, int customerPIN)
        {
            return View(new LoginModel() { CustomerName = customerName, CustomerPIN = customerPIN });
        }
    }
}
