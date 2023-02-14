using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class StatementModel
    {
        [Required(ErrorMessage = "CustomerName cannot be null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "AccountIBAN cannot be null.")]
        public string? AccountIBAN { get; set; }

        [Required(ErrorMessage = "CurrentAccount cannot be null.")]
        public string? AccountName { get; set; }
    }
}
