using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage = "Please enter name of the customer.")]
        public string? CustomerName { get; set; }
    }
}
