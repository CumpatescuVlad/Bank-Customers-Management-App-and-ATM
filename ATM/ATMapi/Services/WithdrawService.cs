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
        private readonly IReadData _readData;

        public WithdrawService(IModifyData modifyData, IGenerateRecipts generateRecipts, IReadData readData)
        {
            _modifyData = modifyData;
            _generateRecipts = generateRecipts;
            _readData = readData;
        }

        public HttpStatusCode WithdrawBallance(WithdrawModel withdrawModel)
        {
            var transactionModel = new TransactionModel()
            {
                AccountOwnerName = withdrawModel.AccountOwnerName,
                AccountIBAN = withdrawModel.AccountIBAN,
                AccountNumber = withdrawModel.AccountNumber,
                Amount = withdrawModel.Amount,
                TypeOfTransaction = "Withdraw",

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

            var withdrawBallance = _modifyData.Withdraw(withdrawModel);

            if (withdrawBallance is HttpStatusCode.Continue)
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
