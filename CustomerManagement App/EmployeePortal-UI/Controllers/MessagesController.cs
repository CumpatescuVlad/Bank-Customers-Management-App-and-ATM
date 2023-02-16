using Microsoft.AspNetCore.Mvc;
using EmployeePortal_UI.Models;
using System.Web;

namespace EmployeePortal_UI.Controllers
{
    public class MessagesController : Controller
    {
        [HttpGet]
        [Route("Succes/{status}")]
        public IActionResult SuccesTAB(string status)
        {
            var statusDecoded = HttpUtility.UrlDecode(status);

           return View(new StatusModel() { Status = statusDecoded });
        }

        [HttpGet]
        [Route("Error/{status}")]
        public IActionResult ErrorTAB(string status)
        {
            var statusDecoded = HttpUtility.UrlDecode(status);

            return View(new StatusModel() { Status = statusDecoded });
        }

    }
}
