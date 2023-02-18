using EmployeePortal__API.BusinessLogic.Modeles;
using EmployeePortal__API.DataAcces.ModifyData.UpdateData;
using EmployeePortal__API.DataAcces.ReadData;
using EmployeePortal__API.Persistence;
using System.Net;

namespace EmployeePortal__API.Services
{
    public class FunctionsService : IFunctionsService
    {
        private readonly IUpdateData _updateData;
        private readonly IReadAccountData _readAccountData;
        private readonly IGenerateStatement _generateStatement;

        public FunctionsService(IUpdateData updateData, IReadAccountData readAccountData, IGenerateStatement generateStatement)
        {
            _updateData = updateData;
            _readAccountData = readAccountData;
            _generateStatement = generateStatement;
        }

        public HttpStatusCode RegenerateCardPinCode(string customerName)
        {
            var updatePinCodeRespone = _updateData.UpdateCreditCard(customerName);

            if (updatePinCodeRespone is HttpStatusCode.InternalServerError)
            {
                return HttpStatusCode.InternalServerError;
            }

            return HttpStatusCode.OK;
        }

        public HttpStatusCode CreateStatement(StatementModel statementModel)
        {
            var transactionsDTO = _readAccountData.ReadTransactions(statementModel.CustomerName);
            string atmTransactions = "No Content";
            string incomeTransactions = "No Content";
            string outcomeTransactions = "No Content";
            string transactions = "No Content";
            foreach (var transaction in transactionsDTO.AtmTransactions)
            {
                atmTransactions += $"{transaction.TypeOfTransaction} {transaction.AccountUsed} {transaction.Amount} {transaction.TransactionDate}\n";
            }
            foreach (var transaction in transactionsDTO.IncomeTransactions)
            {
                incomeTransactions += $"{transaction.TypeOfTransfer} {transaction.AccountUsed} {transaction.Sender} {transaction.Amount} {transaction.TransactionDate}\n";
            }
            foreach (var transaction in transactionsDTO.OutcomeTransactions)
            {
                outcomeTransactions += $"{transaction.TypeOfTransfer} {transaction.AccountUsed} {transaction.Recipient} {transaction.Amount} {transaction.TransactionDate}\n";
            }

            transactions = $"{atmTransactions}{incomeTransactions}{outcomeTransactions}";

            var statementGenerationResult = _generateStatement.GenerateWordStatement(statementModel, transactions);

            return statementGenerationResult;

        }

        public byte[] GetStatement()
        {
            string statementPath = @$"{Environment.CurrentDirectory}\Statements\WordStatements\Statement.doc";

            if (System.IO.File.Exists(statementPath))
            {
                return null;
            }

            return System.IO.File.ReadAllBytes(statementPath);

        }
    }
}
