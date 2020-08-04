﻿ namespace Claros.Interfaces.CSharp.Core
{
    /// <summary>
    /// Usage is discouraged, should probably use ApiError protobuf object instead
    /// </summary>
    public interface IErrorCode
    {
        FacadeStatusCode StatusCode { get; }
        string Code { get; }
        string ErrorDetail { get; }
    }
}
