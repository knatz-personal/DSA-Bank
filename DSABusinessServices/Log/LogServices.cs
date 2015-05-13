using System;
using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Logs;

namespace DSABusinessServices.Log
{
    public class LogServices : ILogServices
    {
        public void DeleteError(int id)
        {
            new ErrorsRepo().Delete(new ErrorLog
            {
                ID = id
            });
        }

        public void DeleteEvent(int id)
        {
            new EventsRepo().Delete(new EventLog
            {
                ID = id
            });
        }

        public IQueryable<ErrorView> ListErrors()
        {
            return new ErrorsRepo().ListAll().Select(er => new ErrorView
            {
                ID = er.ID,
                Username = er.Username,
                DateTriggered = er.DateTriggered,
                InnerException = er.InnerException,
                Message = er.Message
            });
        }

        public IQueryable<EventView> ListEvents()
        {
            return new EventsRepo().ListAll().Select(er => new EventView
            {
                ID = er.ID,
                ModifiedBy = er.ModifiedBy,
                DateModified = er.DateModified,
                SourceTable = er.SourceTable,
                Message = er.Message
            });
        }

        public void LogError(string username, string message, string innerException)
        {
            new ErrorsRepo().Create(new ErrorLog
            {
                DateTriggered = DateTime.Now,
                InnerException = innerException,
                Message = message,
                Username = username
            });
        }

        public void LogEvent(string username, string message, string source)
        {
            new EventsRepo().Create(new EventLog
            {
                DateModified = DateTime.Now,
                SourceTable = source,
                Message = message,
                ModifiedBy = username
            });
        }
    }
}