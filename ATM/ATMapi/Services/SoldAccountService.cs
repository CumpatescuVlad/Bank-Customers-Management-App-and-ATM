using ATMapi.BusinessLogic.Modeles;
using ATMapi.DataAcces;
using ATMapi.PersistenceLayer;
using Newtonsoft.Json;

namespace ATMapi.Services
{
    public class SoldAccountService : ISoldAccountService
    {

        private readonly IGenerateRecipts _generateRecipt;
        private readonly IReadData _readData;

        public SoldAccountService(IGenerateRecipts generateRecipt, IReadData readData)
        {
            _generateRecipt = generateRecipt;
            _readData = readData;
        }

        public string SoldAccount(string customerName, string accountNumber)
        {
            var accountInfo = _readData.ReadAccountInfo(customerName, accountNumber);

            if (accountInfo is not null)
            {
                return JsonConvert.SerializeObject(accountInfo);

            }
            else
            {
                return null;
            }

        }
        public string CreateSoldRecipt(string accountNumber,string accountIBAN,int ballance)
        {
            var soldRecipt = _generateRecipt.GenerateSoldRecipt(accountNumber, accountIBAN, ballance);

            return JsonConvert.SerializeObject(soldRecipt);
        }


    }
}
