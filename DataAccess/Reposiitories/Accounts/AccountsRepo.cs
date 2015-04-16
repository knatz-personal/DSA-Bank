using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Accounts
{
    public class AccountsRepo : IDataRepository<Account>
    {
        private DsaDataContext _db = new DsaDataContext();

        public void Create(Account newItem)
        {
            _db.Accounts.Add(newItem);
            _db.SaveChanges();
        }

        public void Delete(Account itemToDelete)
        {
            var o = _db.Accounts.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.Accounts.Remove(o);
                _db.SaveChanges();
            }
        }

        public IQueryable<Account> ListAll()
        {
            return _db.Accounts.AsQueryable();
        }
        public IQueryable<Account> ListByUsername(string username)
        {
            return _db.Accounts.Where(a => a.Username == username);
        }

        public Account Read(Account itemToRead)
        {
            Account result = _db.Accounts.Find(itemToRead.ID);
            return result;
        }

        public void Update(Account updatedItem)
        {
            var o = _db.Accounts.Find(updatedItem.ID);

            if (o != null)
            {
                o.Remarks = updatedItem.Remarks;
                o.AccountType = updatedItem.AccountType;
                o.TypeID = updatedItem.TypeID;
                o.Balance = updatedItem.Balance;
                o.DateOpened = updatedItem.DateOpened;
                o.ExpiryDate = updatedItem.ExpiryDate;
                o.Currency = updatedItem.Currency;
                o.Name = updatedItem.Name;

                _db.SaveChanges();
            }
        }
    }
}