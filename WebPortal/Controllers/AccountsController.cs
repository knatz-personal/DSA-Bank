using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WebPortal.Models;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserServicesClient client = new UserServicesClient();

        public ActionResult Manage()
        {
            IEnumerable<UserViewModel> list = client.ListUsers().Select(u => new UserViewModel
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

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                String securityToken = model.SecurityToken;
                using (var client = new UserServicesClient())
                {
                    try
                    {
                        if (client.Authenticate(model.Username, model.Password))
                        {
                            FormsAuthentication.RedirectFromLoginPage(model.Username, model.Remember);
                            return RedirectToAction("Index", "Home");
                        }
                        ModelState.AddModelError("", "The user name or security details provided are incorrect.");
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "The user name or security details provided are incorrect.");
                        ModelState.AddModelError("", ex.Message);
                    }
                   
                }
            }
            return Login();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //return RedirectToAction("Index", "Home");
                    ModelState.AddModelError("", "Registration failed.");
                }
                return Register();
            }
            catch
            {
                return View();
            }
        }
    }
}