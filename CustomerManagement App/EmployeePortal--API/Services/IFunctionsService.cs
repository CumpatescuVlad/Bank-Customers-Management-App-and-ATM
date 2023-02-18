using EmployeePortal__API.BusinessLogic.Modeles;
using System.Net;

namespace EmployeePortal__API.Services
{
    public interface IFunctionsService
    {
        HttpStatusCode RegenerateCardPinCode(string customerName);

        HttpStatusCode CreateStatement(StatementModel statementModel);
        
    }
}