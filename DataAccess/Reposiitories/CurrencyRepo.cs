using System;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    public class CurrencyRepo : IDataRepository<Currency>
    {
        private readonly DsaDataContext _db = new DsaDataContext();

        public IQueryable<Currency> ListAll()
        {
            return _db.Currencies.AsQueryable();
        }

        public void Create(Currency newItem)
        {
            _db.Currencies.Add(newItem);
            _db.SaveChanges();
        }

        public Currency Read(Currency itemToRead)
        {
            Currency result = _db.Currencies.Find(itemToRead.Name);
            return result;
        }

        public void Update(Currency updatedItem)
        {
            var o = _db.Currencies.Find(updatedItem.Name);

            if (o != null)
            {
                o.Description = updatedItem.Description;
                _db.SaveChanges();
            }
        }

        public void Delete(Currency itemToDelete)
        {
            var o = _db.Currencies.Find(itemToDelete.Name);

            if (o != null)
            {
                _db.Currencies.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}