using System;
using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Logs;
using DSABusinessServices.BankTransaction;

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

        public IQueryable<ErrorView> FilterErrorsList(string query, DateTime? start, DateTime? end)
        {
             var repo = new ErrorsRepo();
             IQueryable<ErrorLog> list = null;

             list = repo.ListAll().Where(f => f.Username.Contains(query) || f.InnerException.Contains(query) || f.Message.Contains(query)).OrderByDescending(a => a.DateTriggered);

             list = FilterByDateRange(start, end, list);

             return list.Select(er => new ErrorView
            {
                ID = er.ID,
                Username = er.Username,
                DateTriggered = er.DateTriggered,
                InnerException = er.InnerException,
                Message = er.Message
            });
        }

        public IQueryable<EventView> FilterEventsList(string source, DateTime? start, DateTime? end)
        {
             var repo = new EventsRepo();
             IQueryable<EventLog> list = null;

             list = repo.ListAll().Where(f => f.SourceTable.Contains(source)).OrderByDescending(a => a.DateModified);

             list = FilterByDateRange(start, end, list);

             return list.Select(er =>new EventView
            {
                ID = er.ID,
                ModifiedBy = er.ModifiedBy,
                DateModified = er.DateModified,
                SourceTable = er.SourceTable,
                Message = er.Message
            } );
           
        }
        private static IQueryable<ErrorLog> FilterByDateRange(DateTime? start, DateTime? end, IQueryable<ErrorLog> list)
        {
            if (start != null && end != null)
            {
                list = list.Where(apt => apt.DateTriggered >= start && apt.DateTriggered <= end);
            }
            return list;
        }

        private static IQueryable<EventLog> FilterByDateRange(DateTime? start, DateTime? end, IQueryable<EventLog> list)
        {
            if (start != null && end != null)
            {
                list = list.Where(apt => apt.DateModified >= start && apt.DateModified <= end);
            }
            return list;
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