using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Logs
{
    public class ErrorsRepo : IDataRepository<ErrorLog>
    {
        private DsaDataContext _db = new DsaDataContext();
        public IQueryable<ErrorLog> ListAll()
        {
            return _db.ErrorLogs.AsQueryable();
        }

        public void Create(ErrorLog newItem)
        {
            _db.ErrorLogs.Add(newItem);
            _db.SaveChanges();
        }

        public ErrorLog Read(ErrorLog itemToRead)
        {
            ErrorLog result = _db.ErrorLogs.Find(itemToRead.ID);
            return result;
        }

        public void Update(ErrorLog updatedItem)
        {
            var o = _db.ErrorLogs.Find(updatedItem.ID);

            if (o != null)
            {
                o.Message = updatedItem.Message;
                _db.SaveChanges();
            }
        }

        public void Delete(ErrorLog itemToDelete)
        {
            var o = _db.ErrorLogs.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.ErrorLogs.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}