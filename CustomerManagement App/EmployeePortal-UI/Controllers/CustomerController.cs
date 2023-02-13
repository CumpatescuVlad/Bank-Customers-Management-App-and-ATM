using EmployeePortal_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal_UI.Controllers
{
    public class CustomerController : Controller
    {
        //Make a search view

        [HttpGet] public IActionResult DisplayCustomer(CustomerModel customerModel) => View(customerModel);

        [HttpGet] public IActionResult AddCustomer() => View();

        [HttpGet] public IActionResult UpdateCustomer() => View();

        [HttpGet] public IActionResult DeleteCustomer() => View();

        [HttpPost]

        public IActionResult GetCustomers(CustomerModel customerModel)
        {


           return RedirectToAction("DisplayCustomer",new CustomerModel { });    
        }
    }
}
