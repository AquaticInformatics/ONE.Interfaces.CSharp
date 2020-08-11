using System;
using Claros.Common.Core;

namespace Claros.Interfaces.CSharp.Core
{
    public static class SharedErrors
    {
        public static ApiError NotFound => new ApiError
        {
            Code = "ERR-100", 
            Detail = "Could not find the requested information.", 
            StatusCode = (uint) FacadeStatusCode.NotFound
        };

        public static ApiError UnrecognizedDataFormat => new ApiError
        {
            Code = "ERR-101",
            Detail = "Unrecognized Data Format",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError ValidationFailed(string reason = null) => new ApiError
        {
            Code = "ERR-102",
            Detail = $"Validation Failed. Reason: {reason ?? "Not provided"}",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError InvalidRange(string rangeStart, string rangeEnd) => new ApiError
        {
            Code = "ERR-103",
            Detail = $"{rangeEnd} should be greater than {rangeStart}",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError DateTimeTooEarly => new ApiError
        {
            Code = "ERR-104",
            Detail = "Date must be after 1900-01-01 00:00:00",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError ServiceUnavailable(string serviceName) => new ApiError
        {
            Code = "ERR-105",
            Detail = $"Could not connect to service {serviceName}",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError NotAuthorized => new ApiError
        {
            Code = "ERR-106",
            Detail = "User is not authorized to access this resource",
            StatusCode = (uint)FacadeStatusCode.Forbidden
        };

        public static ApiError PropertyIsInvalid(string propertyName) => new ApiError
        {
            Code = "ERR-107",
            Detail = $"{propertyName} is invalid",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError PropertyIsRequired(string propertyName) => new ApiError
        {
            Code = "ERR-108",
            Detail = $"{propertyName} is required",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError PropertyCannotBeNull(string propertyName) => new ApiError
        {
            Code = "ERR-109",
            Detail = $"{propertyName} cannot be null",
            StatusCode = (uint)FacadeStatusCode.BadRequest
        };

        public static ApiError ActionCouldNotBeCompleted(string action) => new ApiError
        {
            Code = "ERR-110",
            Detail = $"{action} could not be completed",
            StatusCode = (uint) FacadeStatusCode.BadRequest
        };

        public static ApiError UnexpectedError(string errorId = null) => new ApiError
        {
            Code = "ERR-500",
            Detail = $"An unexpected error occurred. Code: {(string.IsNullOrWhiteSpace(errorId) ? Guid.NewGuid().ToString() : errorId)}",
            StatusCode = (uint) FacadeStatusCode.InternalServerError
        };
    }
}