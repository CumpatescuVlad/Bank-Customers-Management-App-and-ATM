using System.ComponentModel.DataAnnotations;

namespace EmployeePortal__API.BusinessLogic.Modeles
{
    public class TransactionModel
    {
        [Required(ErrorMessage = "Account Owner Name is required.")]
        public string? AccountOwnerName { get; set; }

        [Required(ErrorMessage = "Order cannot be null or empty.")]
        public string? Order { get; set; }
    }
}
