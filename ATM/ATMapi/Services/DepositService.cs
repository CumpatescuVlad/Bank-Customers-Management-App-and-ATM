using ATMapi.DataAcces;
using ATMapi.Modeles;
using ATMapi.src;
using Newtonsoft.Json;
using System.Net;

namespace ATMapi.Services
{
    public class DepositService : IDepositService
    {
        private readonly IModifyData _modifyData;
        private readonly IGenerateRecipts _generateRecipts;

        public DepositService(IModifyData modifyData, IGenerateRecipts generateRecipts)
        {
            _modifyData = modifyData;
            _generateRecipts = generateRecipts;
        }

        public HttpStatusCode DepositBallance(TransactionModel transactionModel)
        {
            var depositModel = new DepositModel() 
            {
                AccountOwnerName = transactionModel.AccountOwnerName,
                AccountIBAN= transactionModel.AccountIBAN,
                AccountNumber= transactionModel.AccountNumber,
                Amount= transactionModel.Amount,
                DateTime = transactionModel.DateTime,
            };

            var depositBallance = _modifyData.Deposit(depositModel);

            if (depositBallance is HttpStatusCode.Created)
            {
                var insertTransaction = _modifyData.InsertTransaction(transactionModel);

                return insertTransaction;
            }

            return depositBallance;

        }

        public string CreateDepositRecipt(string accountIBAN,int amount)
        {
            string depositRecipt = _generateRecipts.GenerateDepositRecipt(accountIBAN,amount);

            return JsonConvert.SerializeObject(depositRecipt);

        }
    }
}
