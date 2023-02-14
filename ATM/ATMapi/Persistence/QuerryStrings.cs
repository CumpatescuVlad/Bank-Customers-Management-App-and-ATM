using ATMapi.BusinessLogic.Modeles;

namespace ATMapi.PersistenceLayer
{
    public class QuerryStrings
    {
        public static string SelectAccountInfo(string customerName,string accountIBAN) => $"Select CustomerName,AccountNumber,AccountIBAN,Ballance From PersonalAccounts Where CustomerName='{customerName}' AND AccountIBAN='{accountIBAN}'";

        public static string Select(string customerName,string itemToSelect)
        {
            string querryString;

            if(itemToSelect=="ATMPIN")
            {
                querryString = $"Select PinCode From CreditCard Where CustomerName='{customerName}'";
            }
            else 
            {
                querryString = $"Select CustomerName From PersonalAccounts Where CustomerName='{customerName}'";
            }

            return querryString;
        }


        public static string UpdateBallance(DepositModel? depositModel, WithdrawModel? withdrawModel, string typeOfTransaction)
        {
            string querryString;

            if (typeOfTransaction == "Deposit" && depositModel is not null)
            {
                querryString = $"Update PersonalAccounts set Ballance = (Select Ballance From PersonalAccounts Where CustomerName='{depositModel.CustomerName}'AND AccountNumber='{depositModel.AccountNumber}' AND AccountIBAN='{depositModel.AccountIBAN}')+'{depositModel.Amount}' Where CustomerName='{depositModel.CustomerName}'AND AccountNumber='{depositModel.AccountNumber}' AND AccountIBAN='{depositModel.AccountIBAN}'";

            }
            else
            {
                querryString = $"Update PersonalAccounts set Ballance = (Select Ballance From Accounts Where CustomerName='{withdrawModel.CustomerName}'AND AccountNumber='{withdrawModel.AccountNumber}' AND AccountIBAN='{withdrawModel.AccountIBAN}')-'{withdrawModel.Amount}' Where CustomerName='{withdrawModel.CustomerName}'AND AccountNumber='{withdrawModel.AccountNumber}' AND AccountIBAN='{withdrawModel.AccountIBAN}'";
            }

            return querryString;
        }


        public static string InsertTransaction(TransactionModel transactionModel)
        {
            string querryString;

            if (transactionModel.TypeOfTransaction == "Deposit")
            {
                querryString = $"Insert Into ATMTransactions (CustomerName,TypeOfTransaction,AccountUsed,Amount,TransactionDate) Values ('{transactionModel.CustomerName}','Deposit','{transactionModel.AccountIBAN}','{transactionModel.Amount}','{DateTime.Now:yyyy-MM-dd}')";
            }
            else
            {
                querryString = $"Insert Into ATMTransactions (CustomerName,TypeOfTransaction,AccountUsed,Amount,TransactionDate) Values ('{transactionModel.CustomerName}','Withdraw','{transactionModel.AccountIBAN}','{transactionModel.Amount}','{DateTime.Now:yyyy-MM-dd}')";
            }

            return querryString;
        }
    }
}
