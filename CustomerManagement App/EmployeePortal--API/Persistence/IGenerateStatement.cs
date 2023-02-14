using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.Persistence
{
    public interface IGenerateStatement
    {
        HttpStatusCode GenerateWordStatement(StatementModel statementModel, string content);
       
    }
}