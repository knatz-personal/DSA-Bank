using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    public class TownsRepo : IDataRepository<Town>
    {
        private DsaDataContext _db = new DsaDataContext();

        public DsaDataContext Entity
        {
            get { return _db; }
            set { _db = value; }
        }
        #region CRUD
        public IQueryable<Town> ListAll()
        {
            return _db.Towns.AsQueryable();
        }

        public void Create(Town newItem)
        {
            _db.Towns.Add(newItem);
            _db.SaveChanges();
        }

        public Town Read(Town itemToRead)
        {
            var result = _db.Towns.SingleOrDefault(u => u.ID == itemToRead.ID);
            return result;
        }

        public void Update(Town updatedItem)
        {
            _db.Entry(updatedItem).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(Town itemToDelete)
        {
            _db.Towns.Remove(itemToDelete);
            _db.SaveChanges();
        } 
        #endregion
    }
}