using System.ComponentModel.DataAnnotations;

namespace EmployeePortalAPI.BusinessLogic.Models
{
    public class DeleteAccountModel : AccountBase
    {
        [Required(ErrorMessage = "Type of account cannot be null.")]
        public string? TypeOfAccount { get; set; }

    }
}
