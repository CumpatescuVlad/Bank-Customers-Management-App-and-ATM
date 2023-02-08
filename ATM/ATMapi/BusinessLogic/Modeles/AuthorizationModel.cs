using System.ComponentModel.DataAnnotations;

namespace ATMapi.BusinessLogic.Modeles
{
    public class AuthorizationModel
    {
        [Required(ErrorMessage = "Customer Name must not be null.")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Pin must not be null.")]
        public int Pin { get; set; }
    }
}
