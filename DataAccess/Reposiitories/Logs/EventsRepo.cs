using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Logs
{
    public class EventsRepo : IDataRepository<EventLog>
    {
        private readonly DsaDataContext _db = new DsaDataContext();

        public IQueryable<EventLog> ListAll()
        {
            return _db.EventLogs.AsQueryable();
        }

        public void Create(EventLog newItem)
        {
            _db.EventLogs.Add(newItem);
            _db.SaveChanges();
        }

        public EventLog Read(EventLog itemToRead)
        {
            EventLog result = _db.EventLogs.Find(itemToRead.ID);
            return result;
        }

        public void Update(EventLog updatedItem)
        {
            EventLog o = _db.EventLogs.Find(updatedItem.ID);

            if (o != null)
            {
                o.Message = updatedItem.Message;
                _db.SaveChanges();
            }
        }

        public void Delete(EventLog itemToDelete)
        {
            EventLog o = _db.EventLogs.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.EventLogs.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}