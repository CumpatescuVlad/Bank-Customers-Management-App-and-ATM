using System.ComponentModel.DataAnnotations;

namespace ATMapi.DTOs
{
    public class SoldDTO
    {
        public SoldDTO(string? accountOwnerName, string? accountNumber, int? ballance, string? dateTime)
        {
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            Ballance = ballance;
            DateTime = dateTime;
        }

        [Required(ErrorMessage = "Account Name Cannot Be Null.")]
        public string? AccountOwnerName { get; set; }

        [Required(ErrorMessage = "Account Number Cannot Be Null.")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "Amount Cannot Be Null.")]
        public int? Ballance { get; set; }

        [Required(ErrorMessage = "Date Time Cannot Be Null.")]
        public string? DateTime { get; set; }

    }
}
