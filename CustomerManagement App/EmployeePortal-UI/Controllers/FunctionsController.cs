using EmployeePortal_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.Web;

namespace EmployeePortal_UI.Controllers
{
    public class FunctionsController : Controller
    {
        private readonly HttpClient _httpClient;

        public FunctionsController()
        {
            _httpClient= new HttpClient();
            //https://localhost:7214/Portal/CreditCard/RegeneratePinCode
        }

        [HttpGet] public IActionResult FunctionsIndex()=>View();

        [HttpGet] public IActionResult AccountStatement() => View();
       
        [HttpGet] public IActionResult PinCodeRegeneration() => View();

        [HttpPost]

        public IActionResult RegeneratePinCode(CustomerModel customer)
        {
            var uri = "https://localhost:7214/Portal/CreditCard/RegeneratePinCode";
            var customerName = JsonConvert.SerializeObject(customer.CustomerName);
            var content = new StringContent(customerName,Encoding.UTF8, "application/json");
            var pinCodeRegenrationResult = _httpClient.PutAsync(uri,content).Result;

            if (pinCodeRegenrationResult.StatusCode is HttpStatusCode.InternalServerError)
            {
                var errorStatusMessage = HttpUtility.UrlEncode($"Pin Code Regeneration Failed For User {customer.CustomerName}");

                return Redirect($"Error/{errorStatusMessage}");
                
            }
            var succesStatusMessage = HttpUtility.UrlEncode($"Pin Code Succesfully Regenerated For User {customer.CustomerName}");

            return Redirect($"Succes/{succesStatusMessage}");
        }
    }
}
