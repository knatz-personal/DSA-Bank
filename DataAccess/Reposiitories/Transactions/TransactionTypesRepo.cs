using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Transactions
{
    public class TransactionTypesRepo : IDataRepository<TransactionType>
    {
        private DsaDataContext _db = new DsaDataContext();
        public IQueryable<TransactionType> ListAll()
        {
            return _db.TransactionTypes.AsQueryable();
        }

        public void Create(TransactionType newItem)
        {
            _db.TransactionTypes.Add(newItem);
            _db.SaveChanges();
        }

        public TransactionType Read(TransactionType itemToRead)
        {
            TransactionType result = _db.TransactionTypes.Find(itemToRead.ID);
            return result;
        }

        public void Update(TransactionType updatedItem)
        {
            var o = _db.TransactionTypes.Find(updatedItem.ID);

            if (o != null)
            {
                o.Name = updatedItem.Name;
                _db.SaveChanges();
            }
        }

        public void Delete(TransactionType itemToDelete)
        {
            var o = _db.TransactionTypes.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.TransactionTypes.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}