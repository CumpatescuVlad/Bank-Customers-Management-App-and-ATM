namespace EmployeePortal_UI.Models
{
    public class AccountModel
    {
        public string? AccountOwnerName { get; private set; }
        public string? AccountNumber { get; private set; }
        public string? AccountName { get; set; }
        public string? AccountIBAN { get; private set; }
        public int AccountBallance { get; private set; }
    }
}
