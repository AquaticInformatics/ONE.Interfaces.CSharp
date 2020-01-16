namespace Claros.Interfaces.CSharp.Core
{
    public interface IErrorCode
    {
        FacadeStatusCode StatusCode { get; }
        string Code { get; }
        string ErrorDetail { get; }
    }
}
