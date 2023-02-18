using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class UpdateCustomerPhoneNumberModel : SearchModel
    {
        [Required(ErrorMessage = "Please enter new Customer Phone Number.")]
        public string? CustomerPhoneNumber { get; set; }
    }
}
