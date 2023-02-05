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
        private readonly IReadData _readData;

        public DepositService(IModifyData modifyData, IGenerateRecipts generateRecipts, IReadData readData)
        {
            _modifyData = modifyData;
            _generateRecipts = generateRecipts;
            _readData = readData;
        }

        public HttpStatusCode DepositBallance(DepositModel depositModel)
        {
            var transactionModel = new TransactionModel() 
            {
                AccountOwnerName = depositModel.AccountOwnerName,
                AccountIBAN = depositModel.AccountIBAN,
                AccountNumber = depositModel.AccountNumber,
                Amount = depositModel.Amount,
                TypeOfTransaction = "Deposit",
            };

            var customerExists = _readData.ReadCustomer(transactionModel.AccountOwnerName);

            if (customerExists is HttpStatusCode.NotFound)
            {
                return HttpStatusCode.NotFound;
            }
            else if (customerExists is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;

            }

            var depositBallance = _modifyData.Deposit(depositModel);

            if (depositBallance is HttpStatusCode.Created)
            {
                var insertTransaction = _modifyData.InsertTransaction(transactionModel);

                return insertTransaction;
            }

            return depositBallance;

        }

        public string CreateDepositRecipt(string accountIBAN, int amount)
        {
            string depositRecipt = _generateRecipts.GenerateDepositRecipt(accountIBAN, amount);

            return JsonConvert.SerializeObject(depositRecipt);

        }
    }
}
