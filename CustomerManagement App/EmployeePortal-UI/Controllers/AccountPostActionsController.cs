using EmployeePortal_UI.Models;
using EmployeePortal_UI.src;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Web;

namespace EmployeePortal_UI.Controllers
{
    public class AccountPostActionsController : Controller
    {
        private readonly HttpClient _httpClient;

        public AccountPostActionsController()
        {
            _httpClient = new HttpClient();
        }

        [HttpPost]
        public async Task<IActionResult> SearchAccount(SearchModel search)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/AccountViews/SearchAccount.cshtml");
            }
            var accountResult = _httpClient.GetAsync($"https://localhost:7214/Portal/Accounts/AccountInfo/{search.CustomerName}").Result;

            if (accountResult.StatusCode is HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"{accountResult.StatusCode}\" Please Try Again Later.");

                return Redirect($"/Error/{errorMessage}");

            }
            var accountResponse = await accountResult.Content.ReadAsStringAsync().ConfigureAwait(false);
            var accountInfo = JsonConvert.DeserializeObject<List<AccountModel>>(accountResponse);

            return View("~/Views/AccountViews/DisplayAccountInfo.cshtml", accountInfo);
        }

        [HttpPost]
        public async Task<IActionResult> SearchTransactions(SearchModel search)
        {
            ViewData["Name"] = search.CustomerName;
            if (!ModelState.IsValid)
            {
                return View("~/Views/AccountViews/SearchTransactions.cshtml");
            }
            var transactionsResult = _httpClient.GetAsync($"https://localhost:7214/Portal/Accounts/Transactions/{search.CustomerName}").Result;

            if (transactionsResult.StatusCode is HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"{transactionsResult.StatusCode}\" Please Try Again Later.");

                return Redirect($"/Error/{errorMessage}");

            }
            var transactionResponse = await transactionsResult.Content.ReadAsStringAsync().ConfigureAwait(false);
            var transactions = JsonConvert.DeserializeObject<TransactionsModel>(transactionResponse);

            return View("~/Views/AccountViews/DisplayTransactions.cshtml", transactions);
        }

        [HttpPost]
        public IActionResult InsertAccount(InsertAccountModel insertAccount)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/AccountViews/CreateAccount.cshtml");
            }
            var uri = "https://localhost:7214/Portal/Account/CreateAccount";
            var accountData = JsonConvert.SerializeObject(insertAccount);
            var content = new StringContent(accountData, Encoding.UTF8, "application/json");
            var accountResult = _httpClient.PostAsync(uri, content);

            if (Errors.InternalServerErrorFor(accountResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"{accountResult.Status}\" Please Try Again Later.");

                return Redirect($"/Error/{errorMessage}");

            }

            var succesStatus = HttpUtility.UrlEncode($"Account Was Sucesfully Added.\n{insertAccount.CustomerName}\n{insertAccount.AccountName}\n{insertAccount.TypeOfAccount}");

            return Redirect($"/Succes/{succesStatus}");

        }

        [HttpPost]
        public IActionResult DeleteAccount(DeleteAccountModel deleteAccount)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/AccountViews/DeleteAccount.cshtml");
            }
            var uri = "https://localhost:7214/Portal/Account/DeleteAccount";
            var accountData = JsonConvert.SerializeObject(deleteAccount);
            var deleteContent = new StringContent(accountData, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                Content = deleteContent,
                Method = HttpMethod.Delete,
                RequestUri = new Uri(uri),
            };

            var accountResult = _httpClient.SendAsync(request);

            if (Errors.InternalServerErrorFor(accountResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"{accountResult.Status}\" Please Try Again Later.");

                return Redirect($"/Error/{errorMessage}");

            }

            var succesStatus = HttpUtility.UrlEncode($"Account Was Sucesfully Added.\n{deleteAccount.CustomerName}\n{deleteAccount.AccountName}\n{deleteAccount.TypeOfAccount}");

            return Redirect($"/Succes/{succesStatus}");

        }
    }
}
