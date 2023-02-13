using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class AccountBase
    {
        [Required(ErrorMessage = "Account Owner Name cannot be null.")]
        public string? AccountOwnerName { get; set; }

        [Required(ErrorMessage = "Account  Name cannot be null.")]
        public string? AccountName { get; set; }

        [Required(ErrorMessage = "Account  Number cannot be null.")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "Account IBAN cannot be null.")]
        public string? AccountIBAN { get; set; }
    }
}
