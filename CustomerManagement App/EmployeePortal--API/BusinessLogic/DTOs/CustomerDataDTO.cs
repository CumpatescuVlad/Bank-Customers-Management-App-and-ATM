namespace EmployeePortal__API.BusinessLogic.DTOs
{
    public class CustomerDataDTO
    {
        public CustomerDataDTO(string customerName, string customerEmail, string customerPhoneNumber)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhoneNumber = customerPhoneNumber;
        }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }


    }
}
