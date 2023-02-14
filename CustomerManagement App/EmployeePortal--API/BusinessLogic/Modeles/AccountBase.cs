using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class AccountBase
    {
        [Required(ErrorMessage = "Account Owner Name cannot be null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Account  Name cannot be null.")]
        public string? AccountName { get; set; }

    }
}
