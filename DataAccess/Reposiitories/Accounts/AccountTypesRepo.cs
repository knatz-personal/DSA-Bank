using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Accounts
{
    public class AccountTypesRepo : IDataRepository<AccountType>
    {
        private DsaDataContext _db = new DsaDataContext();

        public IQueryable<AccountType> ListAll()
        {
            return _db.AccountTypes.AsQueryable();
        }

        public void Create(AccountType newItem)
        {
            _db.AccountTypes.Add(newItem);
            _db.SaveChanges();
        }

        public AccountType Read(AccountType itemToRead)
        {
            AccountType result = _db.AccountTypes.Find(itemToRead.ID);
            return result;
        }

        public void Update(AccountType updatedItem)
        {
            var o = _db.AccountTypes.Find(updatedItem.ID);

            if (o != null)
            {
                o.Name = updatedItem.Name;
                _db.SaveChanges();
            }
        }

        public void Delete(AccountType itemToDelete)
        {
            var o = _db.AccountTypes.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.AccountTypes.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}