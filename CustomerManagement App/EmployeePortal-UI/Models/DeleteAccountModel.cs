using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class DeleteAccountModel
    {
        [Required(ErrorMessage = "Account Owner Name cannot be null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Account  Name cannot be null.")]
        public string? AccountName { get; set; }

        [Required(ErrorMessage = "Type of account cannot be null.")]
        public string? TypeOfAccount { get; set; }
    }
}
