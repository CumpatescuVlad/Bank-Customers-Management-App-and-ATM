using EmployeePortal_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal_UI.Controllers
{
    public class AccountViewsController : Controller
    {
        [HttpGet] public IActionResult AccountsIndex() => View();

        [HttpGet] public IActionResult SearchAccount() => View();

        [HttpGet] public IActionResult DisplayAccountInfo(AccountModel accountModel) => View(accountModel);

        [HttpGet] public IActionResult CreateAccount() => View();

        [HttpGet] public IActionResult DeleteAccount() => View();

        [HttpGet] public IActionResult SearchTransactions() => View();

        [HttpGet] public IActionResult DisplayTransactions() => View();

    }
}
