using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class DeleteAccountModel : AccountBase
    {
        [Required(ErrorMessage = "Type of account cannot be null.")]
        public string? TypeOfAccount { get; set; }

    }
}
