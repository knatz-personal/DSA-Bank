using System;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Logs;

namespace DSABusinessServices.Log
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