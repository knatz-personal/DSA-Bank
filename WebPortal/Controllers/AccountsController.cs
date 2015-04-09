using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WebPortal.Models;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AccountsController : Controller
    {
        public PartialViewResult Details(string id)
        {
            using (UserServicesClient client = new UserServicesClient())
            {
                var u = client.ReadByUsername(id);
                return PartialView("_Details", new UserViewModel()
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
            }
        }

        public PartialViewResult Edit(string id)
        {
            using (UserServicesClient client = new UserServicesClient())
            {
                var u = client.ReadByUsername(id);
                return PartialView("_Edit", new UserViewModel()
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
            }
        }

        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult Edit(string id, UserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
                }

                return null;
            }
            catch
            {
                return Edit(id);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [AllowAnonymous]
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
                        ModelState.AddModelError(string.Empty, @"The user name or security details provided are incorrect.");
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", @"The user name or security details provided are incorrect.");
                        ModelState.AddModelError("", ex.Message);
                    }

                }
            }
            return Login();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Manage()
        {
            using (UserServicesClient client = new UserServicesClient())
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
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //return RedirectToAction("Index", "Home");
                    ModelState.AddModelError(string.Empty, @"Registration failed.");
                }
                return Register();
            }
            catch
            {
                return View();
            }
        }

        public PartialViewResult Delete(string id)
        {
            using (UserServicesClient client = new UserServicesClient())
            {
                var u = client.ReadByUsername(id);
                return PartialView("_Delete", new UserViewModel()
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
            }
        }

        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Delete(string id, UserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
                }

                return null;
            }
            catch
            {
                return Delete(id);
            }
        }
    }
}