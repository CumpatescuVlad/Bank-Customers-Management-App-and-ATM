﻿using System.ComponentModel.DataAnnotations;

namespace ATMapi.Modeles
{
    public class TransactionModel : DepositModel
    {
        [Required(ErrorMessage ="Type of transaction must be specified")]
        public string? TypeOfTransaction { get; set; }

    }
}