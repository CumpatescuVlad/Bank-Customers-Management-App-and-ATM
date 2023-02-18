using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class CreateAccountModel : AccountBase
    {
        [Required(ErrorMessage = "Type of account cannot be null.")]
        [Display(Name = "PersonalAccount or BusinessAccount")]
        public string? TypeOfAccount { get; set; }

        [Required(ErrorMessage = "Ballance cannot be null.")]
        public int Ballance { get; set; }


    }
}
