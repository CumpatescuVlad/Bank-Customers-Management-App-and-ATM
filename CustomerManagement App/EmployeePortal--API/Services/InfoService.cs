using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.DataAcces.ReadData;
using Newtonsoft.Json;

namespace EmployeePortal__API.Services
{
    public class InfoService : IInfoService
    {
        private readonly IReadCustomerData _readCustomerData;
        private readonly IReadAccountData _readAccountData;
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
            bool transactionsNotFound = false;
            var transactionsList = _readAccountData.ReadTransactions(transactionModel);

            if (transactionsList is null)
            {
                return null;
            }
            foreach (var transaction in transactionsList)
            {
               transactionsNotFound = transaction.AccountOwnerName == "No Owner Was Found" || transaction.Recipient == "No Account Name Was Found" ||
                 transaction.AccountIBAN == "No IBAN Was Found" || transaction.Amount == 0 || transaction.TypeOfTransaction == "No Account Number Was Found" ||
                 transaction.Date == "No Date Was Found";
            }

            if (transactionsNotFound)
            {
                return JsonConvert.SerializeObject(transactionsList);
            }

            return JsonConvert.SerializeObject(transactionsList);

        }
    }
}
