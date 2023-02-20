using EmployeePortal_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace EmployeePortal_UI.Controllers
{
    public class StatusController : Controller
    {
        [HttpGet]
        [Route("Succes/{status}")]
        public IActionResult SuccesTAB(string status)
        {
            var statusDecoded = HttpUtility.UrlDecode(status);
            var succesImagePath = "operation-sucesfully.png";
            return View(new StatusModel() { Status = statusDecoded, Image = succesImagePath });
        }

        [HttpGet]
        [Route("Error/{status}")]
        public IActionResult ErrorTAB(string status)
        {
            var statusDecoded = HttpUtility.UrlDecode(status);
            var serverDownImagePath = "server-down.png";
            return View(new StatusModel() { Status = statusDecoded, Image = serverDownImagePath });
        }

    }
}
