﻿using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class CreateAccountModel : AccountBase
    {
        [Required(ErrorMessage = "Ballance cannot be null.")]
        public int Ballance { get; set; }

        [Required(ErrorMessage = "Type of account cannot be null.")]
        public string? TypeOfAccount { get; set; }
    }
}
