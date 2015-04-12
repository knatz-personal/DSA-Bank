using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    /// <summary>
    ///     Roles Repository
    /// </summary>
    public class RolesRepo : IDataRepository<Role>
    {
        private DsaDataContext _db = new DsaDataContext();

        #region CRUD
        public IQueryable<Role> ListAll()
        {
            return _db.Roles.AsQueryable();
        }

        public void Create(Role newItem)
        {
            _db.Roles.Add(newItem);
            _db.SaveChanges();
        }

        public Role Read(Role itemToRead)
        {
            var result = _db.Roles.SingleOrDefault(u => u.ID == itemToRead.ID);
            return result;
        }

        public void Update(Role updatedItem)
        {
            _db.Entry(updatedItem).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(Role itemToDelete)
        {
            _db.Roles.Remove(itemToDelete);
            _db.SaveChanges();
        } 
        #endregion

        private User GetUser(string username)
        {
            User singleOrDefault = _db.Users.SingleOrDefault(u => u.Username.Equals(username));
            return singleOrDefault;
        }

        public void Allocate(string username, int roleId)
        {
            User us = GetUser(username);
            Role rol = GetRole(roleId);
            if (us != null && rol != null)
            {
                us.Roles.Add(rol);
            }
            _db.SaveChanges();
        }

        private Role GetRole(int roleId)
        {
            Role singleOrDefault = _db.Roles.SingleOrDefault(r => r.ID == roleId);
            return singleOrDefault;
        }

        public void DeAllocate(string username, int roleId)
        {
            User us = GetUser(username);
            Role rol = GetRole(roleId);
            if (us != null && rol != null)
            {
                us.Roles.Remove(rol);
            }
            _db.SaveChanges();
        }

        public void DeAllocateAll(string username, IEnumerable<Role> roleList)
        {
            User us = GetUser(username);
            foreach (Role role in roleList)
            {
                us.Roles.Remove(Read(role));
            }
            _db.SaveChanges();
        }

        public IQueryable<Role> GetRolesOfUser(string username)
        {
            User user = GetUser(username);
            IQueryable<Role> result = user.Roles.Select(r => r).AsQueryable();
            return result;
        }

        public Role GetRoleByName(string name)
        {
            Role singleOrDefault = _db.Roles.SingleOrDefault(r => r.Name == name);
            return singleOrDefault;
        }
    }
}