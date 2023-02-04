namespace ATMapi.DTOs
{
    public class SoldDTO
    {
        public SoldDTO(string? accountOwnerName, string? accountNumber, string accountIBAN, int? ballance, string? dateTime)
        {
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            AccountIBAN = accountIBAN;
            Ballance = ballance;
            DateTime = dateTime;
        }

        public string? AccountOwnerName { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountIBAN { get; set; }

        public int? Ballance { get; set; }

        public string? DateTime { get; set; }

    }
}
