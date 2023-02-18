using System.Net;

namespace EmployeePortal_UI.src
{
    public class Errors
    {
        public static bool RequestFailedFor(Task<HttpResponseMessage> response) => response.Result.StatusCode is HttpStatusCode.BadRequest || response.Result.StatusCode is HttpStatusCode.UnprocessableEntity;

        public static bool InternalServerErrorFor(Task<HttpResponseMessage> response) => response.Result.StatusCode is HttpStatusCode.InternalServerError;

    }
}
