using System;

namespace Claros.Interfaces.CSharp.Core
{
    [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
    public enum FacadeStatusCode
    {
        Ok = 200,
        Created = 201,
        Accepted = 202,
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}
