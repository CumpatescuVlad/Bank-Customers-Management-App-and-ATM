using EmployeePortal_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Web;

namespace EmployeePortal_UI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HttpClient _httpClient;

        public CustomerController()
        {
            _httpClient = new HttpClient();

        }
        //Make a search view

        [HttpGet] public IActionResult CustomerManagementIndex() => View();

        [HttpGet] public IActionResult SearchCustomer() => View();

        [HttpGet] public IActionResult AddCustomer() => View();

        [HttpGet] public IActionResult UpdateCustomer() => View();

        [HttpGet] public IActionResult DeleteCustomer() => View();

        [HttpGet] public IActionResult DisplayCustomers(CustomerModel customer) => View(customer);
      
        [HttpPost]

        public IActionResult GetCustomers(InputModel input)
        {
            var customersResponse = _httpClient.GetStringAsync($"https://localhost:7214/Portal/Customer/Info/{input.CustomerName}");
            if (customersResponse.Status is (TaskStatus)HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode("Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");

                return Redirect($"Error/{errorMessage}");
            }
            
            var customerObject = JsonConvert.DeserializeObject<CustomerModel>(customersResponse.Result);
          
            return RedirectToAction("DisplayCustomers",customerObject);    
        }

        [HttpPost]

        public IActionResult InsertCustomer(AddCustomerModel addCustomerModel)
        {
            var uri = "https://localhost:7214/Portal/Customer/AddNewCustomer";
            var customerModel = JsonConvert.SerializeObject(addCustomerModel);
            var content = new StringContent(customerModel,Encoding.UTF8,"application/json");
            
            var insertCustomerResult = _httpClient.PostAsync(uri,content).Result;

            if (insertCustomerResult.StatusCode is HttpStatusCode.BadRequest|| insertCustomerResult.StatusCode is HttpStatusCode.UnprocessableEntity)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{insertCustomerResult.StatusCode}");

                return Redirect($"/Error/{errorMessage}");
            }

            else if (insertCustomerResult.StatusCode is HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode("Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");

                return Redirect($"/Error/{errorMessage}");
            }
            
            var succesStatus = HttpUtility.UrlEncode("Customer Was Sucesfully Added.");

            return Redirect($"/Succes/{succesStatus}");
        }

        [HttpPost]

        public IActionResult UpdateCustomerData(UpdateCustomerModel updateModel)
        {
            var uri = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var data = JsonConvert.SerializeObject(updateModel);
            var content = new StringContent(data,Encoding.UTF8,"application/json");

            var uppdateDataResult = _httpClient.PutAsync(uri,content);

            if (uppdateDataResult.Result.StatusCode is HttpStatusCode.BadRequest|| uppdateDataResult.Result.StatusCode is HttpStatusCode.UnprocessableEntity)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{uppdateDataResult.Result.StatusCode}");
                return Redirect($"/Error/{errorMessage}");
            }
            else if (uppdateDataResult.Result.StatusCode is HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");
                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Was Sucesfully Added.");

            return Redirect($"/Succes/{succesStatus}");
        }

        [HttpPost]

        public IActionResult DeleteCustomerData(InputModel input)
        {
            var uri = $"https://localhost:7214/Portal/Customer/DeleteCustomer/{input.CustomerName}";
            var deleteDataResult = _httpClient.DeleteAsync(uri);

            if (deleteDataResult.Result.StatusCode is HttpStatusCode.BadRequest || deleteDataResult.Result.StatusCode is HttpStatusCode.UnprocessableEntity)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{deleteDataResult.Result.StatusCode}");
                return Redirect($"/Error/{errorMessage}");
            }
            else if (deleteDataResult.Result.StatusCode is HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");
                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Was Sucesfully Added.");

            return Redirect($"/Succes/{succesStatus}");
        }
    }
}
