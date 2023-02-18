using System.ComponentModel.DataAnnotations;

namespace EmployeePortal_UI.Models
{
    public class StatementModel : SearchModel
    {
        [Required(ErrorMessage = "Please Enter Account IBAN.")]
        public string? AccountIBAN { get; set; }

        [Required(ErrorMessage = "Plese enter account name.")]
        public string? AccountName { get; set; }
    }
}
