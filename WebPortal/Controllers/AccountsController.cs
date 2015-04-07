using System.Linq;
using System.Web.Mvc;
using WebPortal.Models;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    public class AccountsController : Controller
    {
        private UserServicesClient client = new UserServicesClient();
       
        public ActionResult Manage()
        {
            var list = client.ListUsers().Select(u => new UserModel()
            {
                Username = u.Username,
                Password = u.Password,
                FirstName = u.FirstName,
                MiddleInitial = u.MiddleInitial,
                LastName = u.LastName,
                Email = u.Email,
                Mobile = u.Mobile,
                DateOfBirth = u.DateOfBirth,
                Address = u.Address,
                GenderID = u.GenderID,
                TownID = u.TownID,
                TypeID = u.TypeID,
                Blocked = u.Blocked,
                NoOfAttempts = u.NoOfAttempts
            });
            return View(list);

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            try
            {
                return null;
            }
            catch
            {
                return View();
            }
        }
    }
}