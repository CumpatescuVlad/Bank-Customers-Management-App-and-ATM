using EmployeePortal__API.BusinessLogic.DTOs;
using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.Persistence
{
    public interface IGenerateStatement
    {
        HttpStatusCode GenerateWordStatement(StatementModel statementModel, TransactionsDTO transactions);

    }
}