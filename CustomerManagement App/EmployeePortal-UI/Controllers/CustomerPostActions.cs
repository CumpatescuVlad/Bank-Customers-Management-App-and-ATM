using EmployeePortal_UI.Models;
using EmployeePortal_UI.src;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Web;


namespace EmployeePortal_UI.Controllers
{
    public class CustomerPostActions : Controller
    {
        private readonly HttpClient _httpClient;

        public CustomerPostActions()
        {
            _httpClient = new HttpClient();
        }

        [HttpPost]

        public IActionResult GetCustomers(SearchModel search)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/CustomerViews/SearchCustomer.cshtml");
            }

            var customersResponse = _httpClient.GetStringAsync($"https://localhost:7214/Portal/Customer/Info/{search.CustomerName}");
            if (customersResponse.Status is (TaskStatus)HttpStatusCode.InternalServerError)
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"{customersResponse.Status}\" Please Try Again Later.");

                return Redirect($"Error/{errorMessage}");
            }

            var customerData = JsonConvert.DeserializeObject<CustomerModel>(customersResponse.Result);

            return RedirectToAction("DisplayCustomers", "CustomerViews", customerData);
        }

        [HttpPost]

        public IActionResult InsertCustomer(InsertCustomerModel addCustomerModel)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/CustomerViews/AddCustomer.cshtml");
            }

            var uri = "https://localhost:7214/Portal/Customer/AddNewCustomer";
            var customerModel = JsonConvert.SerializeObject(addCustomerModel);
            var customerData = new StringContent(customerModel, Encoding.UTF8, "application/json");

            var insertCustomerResult = _httpClient.PostAsync(uri, customerData);

            if (Errors.RequestFailedFor(insertCustomerResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{insertCustomerResult.Result.StatusCode}");

                return Redirect($"/Error/{errorMessage}");
            }
            else if (Errors.InternalServerErrorFor(insertCustomerResult))
            {
                var errorMessage = HttpUtility.UrlEncode("Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");

                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Was Sucesfully Added.");

            return Redirect($"/Succes/{succesStatus}");
        }


        [HttpPost]

        public IActionResult UpdateCustomerEmail(UpdateCustomerEmailModel updateEmail)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/CustomerViews/UpdateCustomerEmail.cshtml");
            }

            var customerUpdateModel = new UpdateCustomerModel(updateEmail.CustomerName, "CustomerEmail", updateEmail.CustomerEmail);
            var uri = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var newEmail = JsonConvert.SerializeObject(customerUpdateModel);
            var content = new StringContent(newEmail, Encoding.UTF8, "application/json");

            var uppdateCustomerEmailResult = _httpClient.PutAsync(uri, content);

            if (Errors.RequestFailedFor(uppdateCustomerEmailResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{uppdateCustomerEmailResult.Result.StatusCode}");
                return Redirect($"/Error/{errorMessage}");
            }
            else if (Errors.InternalServerErrorFor(uppdateCustomerEmailResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");
                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Email Was Sucesfully Changed.");

            return Redirect($"/Succes/{succesStatus}");

        }

        [HttpPost]

        public IActionResult UpdateCustomerName(UpdateCustomerNameModel updateName)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/CustomerViews/UpdateCustomerName.cshtml");
            }

            var customerUpdateModel = new UpdateCustomerModel(updateName.CustomerName, "CustomerName", updateName.NewCustomerName);
            var uri = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var newName = JsonConvert.SerializeObject(customerUpdateModel);
            var content = new StringContent(newName, Encoding.UTF8, "application/json");

            var uppdateCustomerResult = _httpClient.PutAsync(uri, content);

            if (Errors.RequestFailedFor(uppdateCustomerResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{uppdateCustomerResult.Result.StatusCode}");
                return Redirect($"/Error/{errorMessage}");
            }
            else if (Errors.InternalServerErrorFor(uppdateCustomerResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");
                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Name Was Sucesfully Changed.");
            return Redirect($"/Succes/{succesStatus}");

        }

        [HttpPost]

        public IActionResult UpdateCustomerPhoneNumber(UpdateCustomerPhoneNumberModel phoneModel)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/CustomerViews/UpdateCustomerPhoneNumber.cshtml");
            }

            var customerUpdateModel = new UpdateCustomerModel(phoneModel.CustomerName, "CustomerName", phoneModel.CustomerPhoneNumber);
            var uri = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var newPhone = JsonConvert.SerializeObject(customerUpdateModel);
            var content = new StringContent(newPhone, Encoding.UTF8, "application/json");

            var uppdateCustomerResult = _httpClient.PutAsync(uri, content);

            if (Errors.RequestFailedFor(uppdateCustomerResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{uppdateCustomerResult.Result.StatusCode}");
                return Redirect($"/Error/{errorMessage}");
            }
            else if (Errors.InternalServerErrorFor(uppdateCustomerResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");
                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Name Was Sucesfully Changed.");
            return Redirect($"/Succes/{succesStatus}");

        }

        [HttpPost]

        public IActionResult DeleteCustomerData(DeleteCustomerModel deleteModel)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/CustomerViews/DeleteCustomer.cshtml");
            }
            var uri = $"https://localhost:7214/Portal/Customer/DeleteCustomer/{deleteModel.CustomerName}";
            var deleteDataResult = _httpClient.DeleteAsync(uri);

            if (Errors.RequestFailedFor(deleteDataResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed. Reason:{deleteDataResult.Result.StatusCode}");
                return Redirect($"/Error/{errorMessage}");
            }
            else if (Errors.InternalServerErrorFor(deleteDataResult))
            {
                var errorMessage = HttpUtility.UrlEncode($"Your Request Cannot Be Processed,Reason:\"Internal Server Error\" Please Try Again Later.");
                return Redirect($"/Error/{errorMessage}");
            }

            var succesStatus = HttpUtility.UrlEncode("Customer Was Sucesfully Added.");

            return Redirect($"/Succes/{succesStatus}");
        }
    }
}
