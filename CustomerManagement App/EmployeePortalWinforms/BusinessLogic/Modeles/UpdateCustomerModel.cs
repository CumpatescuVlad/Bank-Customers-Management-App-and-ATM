
namespace EmployeePortalWinforms.BusinessLogic.Modeles
{
    public class UpdateCustomerModel
    {
        public UpdateCustomerModel(string oldCustomerName, string columnName, string value)
        {
            OldCustomerName = oldCustomerName;
            ColumnName = columnName;
            Value = value;

        }

        public string? OldCustomerName { get; private set; }

        public string? ColumnName { get; private set; }

        public string? Value { get; private set; }
    }
}
