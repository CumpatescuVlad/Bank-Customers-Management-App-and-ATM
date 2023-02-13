namespace EmployeePortal.DTOs
{
    public class CustomerDataDTO
    {
        public CustomerDataDTO(string customerName, string customerPassword, string customerEmail, string customerPhoneNumber)
        {
            CustomerName = customerName;
            CustomerPassword = customerPassword;
            CustomerEmail = customerEmail;
            CustomerPhoneNumber = customerPhoneNumber;
        }

        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }


    }
}
