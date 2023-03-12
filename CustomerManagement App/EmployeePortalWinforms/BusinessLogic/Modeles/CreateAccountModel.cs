namespace EmployeePortalWinforms.BusinessLogic.Modeles
{
    public class CreateAccountModel
    {
        public CreateAccountModel(string customerName,string accountName,string typeOfAccount,int ballance)
        {
            CustomerName = customerName;
            AccountName = accountName;
            TypeOfAccount = typeOfAccount;
            Ballance = ballance;
        }

        public string? CustomerName { get; private set; }

        public string? AccountName { get; private set; }

        public string? TypeOfAccount { get; private set; }

        public int Ballance { get; private set; }
    }
}
