using System.Data;
using System.Data.Entity;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    public class UserTypesRepo : IDataRepository<UserType>
    {
        private DsaDataContext _db = new DsaDataContext();

        #region CRUD

        public IQueryable<UserType> ListAll()
        {
            return _db.UserTypes.AsQueryable();
        }

        public void Create(UserType newItem)
        {
            _db.UserTypes.Add(newItem);
            _db.SaveChanges();
        }

        public UserType Read(UserType itemToRead)
        {
            UserType result = _db.UserTypes.SingleOrDefault(u => u.ID == itemToRead.ID);
            return result;
        }

        public void Update(UserType updatedItem)
        {
            _db.Entry(updatedItem).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(UserType itemToDelete)
        {
            _db.UserTypes.Remove(itemToDelete);
            _db.SaveChanges();
        }

        #endregion
    }
}