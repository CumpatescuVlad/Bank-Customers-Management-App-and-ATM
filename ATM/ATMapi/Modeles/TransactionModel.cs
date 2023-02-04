using System.ComponentModel.DataAnnotations;

namespace ATMapi.Modeles
{
    public class TransactionModel:DepositModel
    {
        [Required(ErrorMessage = "TypeOfTransaction cannot be null.")]
        public string? TypeOfTransaction { get; set; }

        [Required(ErrorMessage = "Recipient Name cannot be null.")]
        public string? Recipient { get; set; }
    }
}
