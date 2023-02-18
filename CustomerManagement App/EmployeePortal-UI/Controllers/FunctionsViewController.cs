using Microsoft.AspNetCore.Mvc;


namespace EmployeePortal_UI.Controllers
{
    public class FunctionsViewController : Controller
    {
        [HttpGet] public IActionResult FunctionsIndex() => View();

        [HttpGet] public IActionResult AccountStatement() => View();

        [HttpGet] public IActionResult PinCodeRegeneration() => View();

    }
}
