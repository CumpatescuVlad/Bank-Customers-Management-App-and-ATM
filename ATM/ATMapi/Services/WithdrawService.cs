using ATMapi.DataAcces;
using ATMapi.Modeles;
using ATMapi.src;
using Newtonsoft.Json;
using System.Net;


namespace ATMapi.Services
{
    public class WithdrawService : IWithdrawService
    {
        private readonly IModifyData _modifyData;
        private readonly IGenerateRecipts _generateRecipts;

        public WithdrawService(IModifyData modifyData, IGenerateRecipts generateRecipts)
        {
            _modifyData = modifyData;
            _generateRecipts = generateRecipts;
        }

        public HttpStatusCode WithdrawBallance(TransactionModel transactionModel)
        {
            var withdrawModel = new WithdrawModel()
            {
                AccountOwnerName = transactionModel.AccountOwnerName,
                AccountIBAN = transactionModel.AccountIBAN,
                AccountNumber = transactionModel.AccountNumber,
                Amount = transactionModel.Amount,
                DateTime = transactionModel.DateTime,
            };
            var withdrawBallance = _modifyData.Withdraw(withdrawModel);

            if (withdrawBallance is HttpStatusCode.Created)
            {
                var registerTransaction = _modifyData.InsertTransaction(transactionModel);

                return registerTransaction;
            }

            return withdrawBallance;
        }

        public string CreateWithdrawRecipt(string accountNumber, int amount)
        {
            string withdrawRecipt = _generateRecipts.GenerateWithdrawRecipt(accountNumber, amount);

            return JsonConvert.SerializeObject(withdrawRecipt);
        }
    }
}
