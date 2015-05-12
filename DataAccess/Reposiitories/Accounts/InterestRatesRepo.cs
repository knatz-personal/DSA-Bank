using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Accounts
{
    public class InterestRatesRepo : IDataRepository<InterestRate>
    {
        private readonly DsaDataContext _db = new DsaDataContext();

        public IQueryable<InterestRate> ListAll()
        {
            return _db.InterestRates.AsQueryable();
        }

        public void Create(InterestRate newItem)
        {
            _db.InterestRates.Add(newItem);
            _db.SaveChanges();
        }

        public InterestRate Read(InterestRate itemToRead)
        {
            InterestRate result = _db.InterestRates.Find(itemToRead.ID);
            return result;
        }

        public void Update(InterestRate updatedItem)
        {
            InterestRate o = _db.InterestRates.Find(updatedItem.ID);

            if (o != null)
            {
                o.Rate = updatedItem.Rate;
               
                _db.SaveChanges();
            }
        }

        public void Delete(InterestRate itemToDelete)
        {
            InterestRate o = _db.InterestRates.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.InterestRates.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}