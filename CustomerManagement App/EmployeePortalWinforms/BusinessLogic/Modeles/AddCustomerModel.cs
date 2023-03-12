
namespace EmployeePortalWinforms.BusinessLogic.Modeles
{
    public class AddCustomerModel
    {
        public AddCustomerModel(string? customerName, string? customerEmail, string? customerPhoneNumber, string? accountName)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhoneNumber = customerPhoneNumber;
            AccountName = accountName;
        }

        public string? CustomerName { get; set; }

        public string? CustomerEmail { get; set; }

        public string? CustomerPhoneNumber { get; set; }

        public string? AccountName { get; set; }
    }
}
