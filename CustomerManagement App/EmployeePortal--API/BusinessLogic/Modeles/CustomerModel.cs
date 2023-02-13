using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class CustomerModel
    {
        [Required(ErrorMessage = "Customer Name is required.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Customer Email cannot be null.")]
        [EmailAddress]
        public string? CustomerEmail { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        
        public string? CustomerPhoneNumber { get; set; }

    }
}
