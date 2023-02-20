using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class UpdateCustomerNameModel : SearchModel
    {
        [Required(ErrorMessage = "Please enter the new Customer Name.")]
        public string? NewCustomerName { get; set; }
    }
}
