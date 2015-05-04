using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankServices.Log
{
    [ServiceContract]
    public interface IErrorLogServices
    {
        [OperationContract]
        void Log(string username, string message, string innerException);
    }
}
