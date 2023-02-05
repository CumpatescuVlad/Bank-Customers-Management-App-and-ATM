using ATMapi.Modeles;
using System.Net;

namespace ATMapi.DataAcces
{
    public interface IModifyData
    {
        HttpStatusCode Deposit(DepositModel depositModel);
        HttpStatusCode InsertTransaction(TransactionModel transactionModel);
        HttpStatusCode Withdraw(WithdrawModel withdrawModel);

    }
}