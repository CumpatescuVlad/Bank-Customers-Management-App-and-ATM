using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class InsertCustomerModel : SearchModel
    {
        [Required(ErrorMessage = "Please enter customer Email adress.")]
        [EmailAddress]
        public string? CustomerEmail { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]

        public string? CustomerPhoneNumber { get; set; }

        [Required(ErrorMessage = "AccountName is  required for new customers.")]

        public string? AccountName { get; set; }
    }
}
