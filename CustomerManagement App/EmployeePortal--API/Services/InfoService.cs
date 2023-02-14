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
            bool accountInfoNotFound = false;
            var accountInfoList = _readAccountData.ReadAccountInfo(customerName);

            if (accountInfoList is null)
            {
                return null;
            }
            
            foreach (var account in accountInfoList)
            {
                accountInfoNotFound = account.AccountOwnerName == "No Owner Was Found";
            }
            if (accountInfoNotFound)
            {
                return JsonConvert.SerializeObject(accountInfoList);
            }

            return JsonConvert.SerializeObject(accountInfoList);
        }

        public string GetAccountTransactions(string customerName)
        {
            bool transactionsNotFound = false;
            var transactionsList = _readAccountData.ReadTransactions(customerName);

            if (transactionsList is null)
            {
                return null;
            }
            foreach (var transaction in transactionsList.AtmTransactions)
            {
                transactionsNotFound = transaction is null;
            }
            foreach (var transaction in transactionsList.IncomeTransactions)
            {
                transactionsNotFound = transaction is null;
            }
            foreach (var transaction in transactionsList.OutcomeTransactions)
            {
                transactionsNotFound = transaction is null;
            }

            if (transactionsNotFound)
            {
                return JsonConvert.SerializeObject(transactionsList);
            }

            return JsonConvert.SerializeObject(transactionsList);

        }
    }
}
