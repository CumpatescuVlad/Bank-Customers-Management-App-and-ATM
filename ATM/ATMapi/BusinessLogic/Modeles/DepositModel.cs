using System.ComponentModel.DataAnnotations;

namespace ATMapi.BusinessLogic.Modeles
{
    public class DepositModel
    {
        [Required(ErrorMessage = "Account Name Cannot Be Null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Account Number Cannot Be Null.")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "Account IBAN Cannot Be Null.")]
        public string? AccountIBAN { get; set; }

        [Required(ErrorMessage = "Amount Cannot Be Null.")]
        public int? Amount { get; set; }

    }
}
