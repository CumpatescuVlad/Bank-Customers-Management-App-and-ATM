using EmployeePortal_UI.Models;
using EmployeePortal_UI.src;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Web;


namespace EmployeePortal_UI.Controllers
{
    public class FunctionsPostActionsController : Controller
    {
        private readonly HttpClient _httpClient;

        public FunctionsPostActionsController()
        {
            _httpClient = new HttpClient();
        }

        [HttpPost]

        public IActionResult RegeneratePinCode(SearchModel search)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/FunctionsView/PinCodeRegeneration.cshtml");
            }

            var uri = "https://localhost:7214/Portal/CreditCard/RegeneratePinCode";
            var customerName = JsonConvert.SerializeObject(search.CustomerName);
            var content = new StringContent(customerName, Encoding.UTF8, "application/json");
            var pinCodeRegenrationResult = _httpClient.PutAsync(uri, content);

            if (Errors.InternalServerErrorFor(pinCodeRegenrationResult))
            {
                var errorStatusMessage = HttpUtility.UrlEncode($"Pin Code Regeneration Failed For User {search.CustomerName}");

                return Redirect($"/Error/{errorStatusMessage}");

            }
            var succesStatusMessage = HttpUtility.UrlEncode($"Pin Code Succesfully Regenerated For User {search.CustomerName}");

            return Redirect($"/Succes/{succesStatusMessage}");
        }

        [HttpPost]

        public async Task<IActionResult> DownloadStatement(StatementModel statement)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/FunctionsView/AccountStatement.cshtml");
            }

            var uri = "https://localhost:7214/Portal/Statements";
            var customerName = JsonConvert.SerializeObject(statement);
            var content = new StringContent(customerName, Encoding.UTF8, "application/json");
            var statementgenrationResult = _httpClient.PostAsync(uri, content);

            if (Errors.InternalServerErrorFor(statementgenrationResult))
            {
                var errorStatusMessage = HttpUtility.UrlEncode($"Statement Generation Failed , Reason:{statementgenrationResult.Result.StatusCode}");

                return Redirect($"/Error/{errorStatusMessage}");

            }
            Task<byte[]> bytes = System.IO.File.ReadAllBytesAsync(@$"E:\CODE REPOS\Bank\Statements\{statement.CustomerName}\{statement.CustomerName}Statement.doc");

            return File(await bytes.ConfigureAwait(false), "word/doc", $"{statement.CustomerName}Statement.doc");


        }
    }
}
