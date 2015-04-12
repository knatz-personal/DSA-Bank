using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    public class TransactionsRepo : IDataRepository<TransactionLog>
    {
        private DsaDataContext _db = new DsaDataContext();

        public IQueryable<TransactionLog> ListAll()
        {
            return _db.Transactions.AsQueryable();
        }

        public void Create(TransactionLog newItem)
        {
            _db.Transactions.Add(newItem);
            _db.SaveChanges();
        }

        public TransactionLog Read(TransactionLog itemToRead)
        {
            TransactionLog result = _db.Transactions.Find(itemToRead.ID);
            return result;
        }

        public void Update(TransactionLog updatedItem)
        {
            var o = _db.Transactions.Find(updatedItem.ID);

            if (o != null)
            {
                o.Remarks = updatedItem.Remarks;
                o.TransactionType = updatedItem.TransactionType;
                o.TypeID = updatedItem.TypeID;
                o.AccountFromID = updatedItem.AccountFromID;
                o.AccountToID = updatedItem.AccountToID;
                o.Amount = updatedItem.Amount;
                o.Currency = updatedItem.Currency;
                o.DateIssued = updatedItem.DateIssued;
                
                _db.SaveChanges();
            }
        }

        public void Delete(TransactionLog itemToDelete)
        {
            var o = _db.Transactions.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.Transactions.Remove(o);
                _db.SaveChanges();
            }
        }

        public IQueryable<TransactionLog> ListByUsername(string username)
        {
            return _db.Transactions.Where(t => t.Account.Username == username || t.Account1.Username == username);
        }
    }
}