using System.ServiceModel;

namespace DSABusinessServices.Log
{
    [ServiceContract]
    public interface IErrorLogServices
    {
        [OperationContract]
        void Log(string username, string message, string innerException);
    }
}
