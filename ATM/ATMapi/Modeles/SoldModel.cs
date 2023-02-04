using System.ComponentModel.DataAnnotations;

namespace ATMapi.Modeles
{
    public class SoldModel
    {
        [Required(ErrorMessage = "Account Number Cannot Be Null.")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "Account IBAN Cannot Be Null.")]
        public string? AccountIBAN { get; set; }

        [Required(ErrorMessage = "Ballance Cannot Be Null.")]
        public int Ballance { get; set; }

    }
}
