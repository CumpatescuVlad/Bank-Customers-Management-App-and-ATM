using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class UpdateCustomerEmailModel :SearchModel
    {
        [Required(ErrorMessage = "Please enrter new Customer Email.")]
        public string? CustomerEmail { get; set; }

    }
}
