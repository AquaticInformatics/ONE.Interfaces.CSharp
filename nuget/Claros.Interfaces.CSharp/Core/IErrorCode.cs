﻿using System;

namespace Claros.Interfaces.CSharp.Core
{
    /// <summary>
    /// Usage is discouraged, should probably use ApiError protobuf object instead
    /// </summary>
    [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
    public interface IErrorCode
    {
        FacadeStatusCode StatusCode { get; }
        string Code { get; }
        string ErrorDetail { get; }
    }
}
