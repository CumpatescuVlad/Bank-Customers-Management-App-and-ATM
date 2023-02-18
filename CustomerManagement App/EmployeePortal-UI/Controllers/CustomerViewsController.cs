using EmployeePortal_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal_UI.Controllers
{
    public class CustomerViewsController : Controller
    {
        [HttpGet] public IActionResult CustomerManagementIndex() => View();

        [HttpGet] public IActionResult SearchCustomer() => View();

        [HttpGet] public IActionResult AddCustomer() => View();

        [HttpGet] public IActionResult UpdateCustomerIndex() => View();

        [HttpGet] public IActionResult UpdateCustomerName() => View();

        [HttpGet] public IActionResult UpdateCustomerPhoneNumber() => View();

        [HttpGet] public IActionResult UpdateCustomerEmail() => View();

        [HttpGet] public IActionResult DeleteCustomer() => View();

        [HttpGet] public IActionResult DisplayCustomers(InsertCustomerModel customer) => View(customer);

    }
}
