namespace EmployeePortal.DTOs
{
    public class AccountDTO
    {
        public AccountDTO(string accountOwnerName, string accountNumber, string accountIBAN, int accountBallance, string accountName)
        {
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountIBAN = accountIBAN;
            AccountBallance = accountBallance;
        }

        public string AccountOwnerName { get; private set; }
        public string AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public string AccountIBAN { get; private set; }
        public int AccountBallance { get; private set; }




    }
}
