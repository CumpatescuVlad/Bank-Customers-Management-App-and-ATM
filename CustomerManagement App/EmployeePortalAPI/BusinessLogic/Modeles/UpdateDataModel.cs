using System.ComponentModel.DataAnnotations;

namespace EmployeePortalAPI.BusinessLogic.Models
{
    public class UpdateDataModel
    {
        [Required(ErrorMessage = "Customer Name cannot be null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Column Name cannot be null.")]
        public string? ColumnName { get; set; }

        [Required(ErrorMessage = "Old Customer Name cannot be null.")]
        public string? OldCustomerName { get; set; }

        [Required(ErrorMessage = "New Value cannot be null.")]
        public string? Value { get; set; }
    }
}
