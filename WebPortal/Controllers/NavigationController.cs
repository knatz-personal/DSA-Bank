using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebPortal.Models;
using WebPortal.NavigationServices;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    public class NavigationController : Controller
    {
        [ChildActionOnly]
        public PartialViewResult _Menu()
        {
            using (var userServicesClient = new UserServicesClient())
            {
                const string anonRole = "Guest";
                const string clientRole = "Customer";
                const string manRole = "Manager";
                const string adminRole = "Administrator";

                int roleId = 0;
                if (User.Identity.IsAuthenticated)
                {
                    if (User.IsInRole(adminRole))
                    {
                        roleId = userServicesClient.GetRoleIdByName(adminRole);
                    }
                    else if (User.IsInRole(manRole))
                    {
                        roleId = userServicesClient.GetRoleIdByName(manRole);
                    }
                    else if (User.IsInRole(clientRole))
                    {
                        roleId = userServicesClient.GetRoleIdByName(clientRole);
                    }
                }
                else
                {
                    roleId = userServicesClient.GetRoleIdByName(anonRole);
                }
                using (var client = new NavigationServicesClient())
                {
                    var model = new MenuViewModel();
                    model.RootMenu = client.GetMenuByRole(roleId).Select(m => new MenuModel()
                    {
                        ID = m.ID,
                        Name = m.Name,
                        Description = m.Description,
                        ActionName = m.ActionName,
                        ControllerName = m.ControllerName,
                        ParentID = m.ParentID,
                        SortOrder = m.SortOrder
                    });
                    model.SubMenu = client.GetSubMenus(roleId).Select(m => new MenuModel()
                    {
                        ID = m.ID,
                        Name = m.Name,
                        Description = m.Description,
                        ActionName = m.ActionName,
                        ControllerName = m.ControllerName,
                        ParentID = m.ParentID,
                        SortOrder = m.SortOrder
                    });
                    return PartialView("_Menu", model);
                }
            }
        }
    }
}