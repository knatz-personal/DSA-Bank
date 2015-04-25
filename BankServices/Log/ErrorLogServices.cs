using System;
using System.ServiceModel.Channels;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Logs;

namespace BankServices.Log
{
    public class ErrorLogServices : IErrorLogServices
    {
        public void Log(string username, string message ,string innerException )
        {
            new ErrorsRepo().Create(new ErrorLog()
            {
                DateTriggered = DateTime.Now,
                InnerException = innerException,
                Message = message,
                Username = username
            });
        }
    }
}