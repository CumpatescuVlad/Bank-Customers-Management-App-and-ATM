using System.ComponentModel.DataAnnotations;

namespace ATMapi.Modeles
{
    public class SoldModel
    {
        [Required(ErrorMessage = "Account Name Cannot Be Null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Account Number Cannot Be Null.")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "You must give a response \"Yes\" or \"No\" .")]
        public string? DoYouWantRecipt { get; set; }

    }
}
