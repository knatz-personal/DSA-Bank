using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    /// <summary>
    ///     Genders Repository 
    /// </summary>
    public class GendersRepo : IDataRepository<Gender>
    {
        private DsaDataContext _db = new DsaDataContext();

        #region CRUD
        public IQueryable<Gender> ListAll()
        {
            return _db.Genders.AsQueryable();
        }

        public void Create(Gender newItem)
        {
            _db.Genders.Add(newItem);
            _db.SaveChanges();
        }

        public Gender Read(Gender itemToRead)
        {
            var result = _db.Genders.Find(itemToRead.ID);
            return result;
        }

        public void Update(Gender updatedItem)
        {
            _db.Entry(updatedItem).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(Gender itemToDelete)
        {
            _db.Genders.Remove(itemToDelete);
            _db.SaveChanges();
        } 
        #endregion
    }
}