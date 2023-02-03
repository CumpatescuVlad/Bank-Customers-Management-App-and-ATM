using ATMapi.DataAcces;
using ATMapi.Modeles;
using ATMapi.src;
using Newtonsoft.Json;

namespace ATMapi.Services
{
    public class SoldAccountService
    {
        private readonly ILogger<SoldAccountService> _logger;
        private readonly IGenerateRecipts _generateRecipt;
        private readonly IReadData _readData;

        public SoldAccountService(ILogger<SoldAccountService> logger,IGenerateRecipts generateRecipt,IReadData readData)
        {
            _logger = logger;
            _generateRecipt= generateRecipt;
            _readData = readData;
        }

        public string SoldAccount(SoldModel soldModel)
        {
            var accountInfo = _readData.ReadAccountInfo(soldModel.CustomerName,soldModel.AccountNumber);
           
            if (accountInfo is not null&&soldModel.DoYouWantRecipt=="No")
            {
                return JsonConvert.SerializeObject(accountInfo);
            }
            else if (accountInfo is not null&&soldModel.DoYouWantRecipt=="Yes")
            {
                return JsonConvert.SerializeObject(_generateRecipt.GenerateSoldRecipt());
            }
            else
            {
                return null;
            }
            

        }



    }
}
