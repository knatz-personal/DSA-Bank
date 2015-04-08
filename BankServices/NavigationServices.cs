using System.Collections.Generic;
using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;

namespace BankServices
{
    public class NavigationServices : INavigationServices
    {
        public IQueryable<MenuView> ListAll()
        {
            return new MenusRepo().ListAll().Select(m => new MenuView
            {
                ID = m.ID,
                Name = m.Name,
                Description = m.Description,
                ActionName = m.ActionName,
                ControllerName = m.ControllerName,
                ParentID = m.ParentID,
                SortOrder = m.SortOrder
            });
        }

        public void Create(MenuView menu)
        {
            new MenusRepo().Create(new Menu
            {
                ID = menu.ID,
                Name = menu.Name,
                Description = menu.Description,
                ActionName = menu.ActionName,
                ControllerName = menu.ControllerName,
                ParentID = menu.ParentID,
                SortOrder = menu.SortOrder
            });
        }

        public MenuView Read(MenuView menu)
        {
            Menu m = new MenusRepo().Read(new Menu {ID = menu.ID});
            return new MenuView
            {
                ID = m.ID,
                Name = m.Name,
                Description = m.Description,
                ActionName = m.ActionName,
                ControllerName = m.ControllerName,
                ParentID = m.ParentID,
                SortOrder = m.SortOrder
            };
        }

        public MenuView Update(MenuView menu)
        {
            new MenusRepo().Update(new Menu
            {
                ID = menu.ID,
                Name = menu.Name,
                Description = menu.Description,
                ActionName = menu.ActionName,
                ControllerName = menu.ControllerName,
                ParentID = menu.ParentID,
                SortOrder = menu.SortOrder
            });
            return menu;
        }

        public void Delete(MenuView menu)
        {
            new MenusRepo().Delete(new Menu
            {
                ID = menu.ID,
                Name = menu.Name,
                Description = menu.Description,
                ActionName = menu.ActionName,
                ControllerName = menu.ControllerName,
                ParentID = menu.ParentID,
                SortOrder = menu.SortOrder
            });
        }

        public IEnumerable<MenuView> GetMenuByRole(int roleId)
        {
            IEnumerable<MenuView> list = new MenusRepo().GetMenuByRole(roleId).Select(m => new MenuView
            {
                ID = m.ID,
                Name = m.Name,
                Description = m.Description,
                ActionName = m.ActionName,
                ControllerName = m.ControllerName,
                ParentID = m.ParentID,
                SortOrder = m.SortOrder
            }); ;
            return list;
        }

        public IEnumerable<MenuView> GetSubMenus(int roleId)
        {
            IEnumerable<MenuView> list = new MenusRepo().GetSubMenus(roleId).Select(m => new MenuView
            {
                ID = m.ID,
                Name = m.Name,
                Description = m.Description,
                ActionName = m.ActionName,
                ControllerName = m.ControllerName,
                ParentID = m.ParentID,
                SortOrder = m.SortOrder
            });
            return list;
        }
    }
}