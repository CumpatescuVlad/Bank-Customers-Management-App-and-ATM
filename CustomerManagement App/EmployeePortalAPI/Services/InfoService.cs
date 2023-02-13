using EmployeePortalAPI.BusinessLogic.Modeles;
using EmployeePortalAPI.DataAcces.ReadData;
using Newtonsoft.Json;


namespace EmployeePortalAPI.Services
{
    public class InfoService : IInfoService
    {
        public IReadCustomerData _readCustomerData;
        public IReadAccountData _readAccountData;
        public InfoService(IReadCustomerData readCustomerData, IReadAccountData readAccountData)
        {
            _readCustomerData = readCustomerData;
            _readAccountData = readAccountData;
        }

        public string GetCustomerInfo(string customerName)
        {
            var customerDTO = _readCustomerData.ReadCustomerInfo(customerName);

            if (customerDTO is null)
            {
                return null;
            }
            else if (customerDTO.CustomerName == "Not Found" || customerDTO.CustomerEmail == "Not Found" || customerDTO.CustomerPhoneNumber == "Not Found")
            {
                return JsonConvert.SerializeObject(customerDTO);
            }

            return JsonConvert.SerializeObject(customerDTO);
        }

        public string GetAccountInfo(string customerName)
        {
            var accountInfoDTO = _readAccountData.ReadAccountInfo(customerName);

            if (accountInfoDTO is null)
            {
                return null;
            }

            bool accountInfoNotFound = accountInfoDTO.AccountOwnerName == "No Owner Was Found" || accountInfoDTO.AccountName == "No Account Name Was Found" ||
                accountInfoDTO.AccountIBAN == "No IBAN Was Found" || accountInfoDTO.AccountBallance == 0 || accountInfoDTO.AccountNumber == "No Account Number Was Found";

            if (accountInfoNotFound)
            {
                return JsonConvert.SerializeObject(accountInfoDTO);
            }

            return JsonConvert.SerializeObject(accountInfoDTO);
        }

        public string GetAccountTransactions(TransactionModel transactionModel)
        {
            var transactionDTO = _readAccountData.ReadTransactions(transactionModel);

            if (transactionDTO is null)
            {
                return null;
            }

            bool transactionsNotFound = transactionDTO.AccountOwnerName == "No Owner Was Found" || transactionDTO.AccountName == "No Account Name Was Found" ||
                transactionDTO.AccountIBAN == "No IBAN Was Found" || transactionDTO.Amount == 0 || transactionDTO.AccountNumber == "No Account Number Was Found" ||
                transactionDTO.Date == "No Date Was Found";

            if (transactionsNotFound)
            {
                return JsonConvert.SerializeObject(transactionDTO);
            }

            return JsonConvert.SerializeObject(transactionDTO);

        }

    }
}
