using System.ComponentModel.DataAnnotations;

namespace ATM_UI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Customer name is required.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Pin code is requred.")]
        public int? PIN { get; set; }

        [Required(ErrorMessage = "Account number is required.")]
        public string? AccountNumber { get; set; }

    }
}
