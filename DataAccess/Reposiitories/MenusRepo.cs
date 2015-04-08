using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    public class MenusRepo : IDataRepository<Menu>
    {
        private DsaDataContext _db = new DsaDataContext();
        #region CRUD
        public IQueryable<Menu> ListAll()
        {
            return _db.Menus.AsQueryable();
        }

        public void Create(Menu newItem)
        {
            _db.Menus.Add(newItem);
            _db.SaveChanges();
        }

        public Menu Read(Menu itemToRead)
        {
            var result = _db.Menus.SingleOrDefault(u => u.ID == itemToRead.ID);
            return result;
        }

        public Menu Update(Menu updatedItem)
        {
            _db.Entry(updatedItem).State = EntityState.Modified;
            _db.SaveChanges();
            return updatedItem;
        }

        public void Delete(Menu itemToDelete)
        {
            _db.Menus.Remove(itemToDelete);
            _db.SaveChanges();
        }
        #endregion

        public IEnumerable<Menu> GetMenuByRole(int roleId)
        {
            Role r = new RolesRepo().Read(new Role(){ID = roleId});

            var result = from mm in r.Menus where mm.ParentID == null || mm.ParentID == 0 orderby mm.SortOrder select mm;

            return result;
        }

        public IEnumerable<Menu> GetSubMenus(int roleId, int parentId)
        {
            Role r = new RolesRepo().Read(new Role() { ID = roleId });

            var result = from mm in r.Menus
                         where mm.ParentID == parentId
                         orderby mm.SortOrder
                         select mm;
            return result;
        }

        public IEnumerable<Menu> GetSubMenus(int roleId)
        {
            Role r = new RolesRepo().Read(new Role() { ID = roleId });

            var result = from mm in r.Menus
                         where mm.ParentID != null || mm.ParentID != 0
                         orderby mm.SortOrder
                         select mm;
            return result;
        }
    }
}