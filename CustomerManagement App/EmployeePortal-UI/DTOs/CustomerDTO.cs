namespace EmployeePortal_UI.DTOs
{
    public class CustomerDTO
    {
        public CustomerDTO(string? columnName, string? oldCustomerName, string? value)
        {
            ColumnName = columnName;
            OldCustomerName = oldCustomerName;
            Value = value;
        }

        public string? ColumnName { get; set; }

        public string? OldCustomerName { get; set; }

        public string? Value { get; set; }
    }
}
