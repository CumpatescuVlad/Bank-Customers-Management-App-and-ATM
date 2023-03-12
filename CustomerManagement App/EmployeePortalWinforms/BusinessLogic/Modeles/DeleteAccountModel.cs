using System.ComponentModel.DataAnnotations;

namespace EmployeePortalWinforms.BusinessLogic.Modeles
{
    public  class DeleteAccountModel
    {
        public DeleteAccountModel(string customerName,string accountName,string typeOfAccount)
        {
            CustomerName = customerName;
            AccountName = accountName;
            TypeOfAccount = typeOfAccount;
        }

        public string? CustomerName { get; set; }
        public string? AccountName { get; set; }
        public string? TypeOfAccount { get; set; }
    }
}
