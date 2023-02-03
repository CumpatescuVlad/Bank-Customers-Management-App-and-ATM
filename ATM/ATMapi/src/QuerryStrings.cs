using ATMapi.Modeles;

namespace ATMapi.src
{
    public  class QuerryStrings
    {
        public static string SelectAccountInfo(string customerName,string accountNumber) => $"Select CustomerName,AccountNumber,AccountIBAN,Ballance From Accounts Where CustomerFullName='{customerName}' AND AccountNumber='{accountNumber}'";

        public static string UpdateBallance(DepositModel? depositModel ,WithdrawModel? withdrawModel,string typeOfTransaction)
        {
            string querryString;

            if (typeOfTransaction == "Deposit"&&depositModel is not null)
            {
                querryString = $"Update Accounts set Ballance = (Select Ballance From Accounts Where CustomerFullName='{depositModel.AccountOwnerName}'AND AccountNumber='{depositModel.AccountNumber}' AND AccountIBAN='{depositModel.AccountIBAN}')+'{depositModel.Amount}') Where CustomerFullName='{depositModel.AccountOwnerName}'AND AccountNumber='{depositModel.AccountNumber}' AND AccountIBAN='{depositModel.AccountIBAN}'";

            }
            else
            {
                querryString = $"Update Accounts set Ballance = (Select Ballance From Accounts Where CustomerFullName='{withdrawModel.AccountOwnerName}'AND AccountNumber='{withdrawModel.AccountNumber}' AND AccountIBAN='{withdrawModel.AccountIBAN}')-'{withdrawModel.Amount}') Where CustomerFullName='{withdrawModel.AccountOwnerName}'AND AccountNumber='{withdrawModel.AccountNumber}' AND AccountIBAN='{withdrawModel.AccountIBAN}'";
            }

            return querryString;
        }


        public static string InsertTransaction(TransactionModel transactionModel)
        {
            string querryString;

            if (transactionModel.TypeOfTransaction=="Deposit")
            {
                querryString = $"Insert Into Transactions (CustomerFullName,TypeOfTransaction,AccountUsed,Amount,Recipient,TransactionDate) Values('{transactionModel.CustomerName}','Deposit','{transactionModel.AccountIBAN}','{transactionModel.Amount}','{transactionModel.Recipient}','{DateTime.Now:yyyy-MM-dd}')";
            }
            else 
            {
                querryString = $"Insert Into Transactions (CustomerFullName,TypeOfTransaction,AccountUsed,Amount,Recipient,TransactionDate) Values('{transactionModel.CustomerName}','Withdraw','{transactionModel.AccountIBAN}','{transactionModel.Amount}','{transactionModel.Recipient}','{DateTime.Now:yyyy-MM-dd}')";
            }

            return querryString;
        }
    }
}
