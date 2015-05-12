using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Accounts
{
    public class FixedTermsRepo : IDataRepository<FixedTerm>
    {
        private DsaDataContext _db = new DsaDataContext();

        public IQueryable<FixedTerm> ListAll()
        {
            return _db.FixedTerms.AsQueryable();
        }

        public void Create(FixedTerm newItem)
        {
            _db.FixedTerms.Add(newItem);
            _db.SaveChanges();
        }

        public FixedTerm Read(FixedTerm itemToRead)
        {
            FixedTerm result = _db.FixedTerms.Find(itemToRead.ID);
            return result;
        }

        public void Update(FixedTerm updatedItem)
        {
            FixedTerm o = _db.FixedTerms.Find(updatedItem.ID);

            if (o != null)
            {
                o.Duration = updatedItem.Duration;
                _db.SaveChanges();
            }
        }

        public void Delete(FixedTerm itemToDelete)
        {
            var o = _db.FixedTerms.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.FixedTerms.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}