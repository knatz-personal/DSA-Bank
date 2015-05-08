using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;
using CommonUtils;
using PagedList;
using WebPortal.Models;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UsersController : Controller
    {
        public PartialViewResult Delete(string id)
        {
            using (var client = new UserServicesClient())
            {
                UserView u = client.ReadByUsername(id);
                return PartialView("_Delete", new UserAccountViewModel
                {
                    Username = u.Username,
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
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (var client = new UserServicesClient())
                {
                    client.Delete(id);
                }
                return Json("OK");
            }
            catch (Exception e)
            {
                return Json(new { Result = "OK", e.Message });
            }
        }

        public PartialViewResult Details(string id)
        {
            using (var client = new UserServicesClient())
            {
                UserView u = client.ReadByUsername(id);
                if (u.TownID != null && u.TypeID != null && u.GenderID != null)
                {
                    return PartialView("_Details", new UserAccountViewModel
                    {
                        Username = u.Username,
                        FirstName = u.FirstName,
                        MiddleInitial = u.MiddleInitial,
                        LastName = u.LastName,
                        Email = u.Email,
                        Mobile = u.Mobile,
                        DateOfBirth = u.DateOfBirth,
                        Address = u.Address,
                        GenderName = u.GenderName,
                        TownName = u.TownName,
                        TypeName = u.TypeName,
                        Blocked = u.Blocked,
                        NoOfAttempts = u.NoOfAttempts
                    });
                }
            }
            return null;
        }

        public PartialViewResult Edit(string id)
        {
            using (var client = new UserServicesClient())
            {
                UserView u = client.ReadByUsername(id);
                return PartialView("_Edit", new UserAccountViewModel
                {
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
                    Username = u.Username,
                    Blocked = u.Blocked,
                    NoOfAttempts = u.NoOfAttempts,
                    Genders = GetGenderList(),
                    Towns = GetTownList(),
                    Types = GetTypeList()
                });
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(string id, UserAccountViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new UserServicesClient())
                    {
                        client.Update(new UserView
                        {
                            Username = id,
                            FirstName = model.FirstName,
                            MiddleInitial = model.MiddleInitial,
                            LastName = model.LastName,
                            Email = model.Email,
                            Mobile = model.Mobile,
                            DateOfBirth = model.DateOfBirth,
                            Address = model.Address,
                            GenderID = model.GenderID,
                            TownID = model.TownID,
                            TypeID = model.TypeID,
                            Blocked = model.Blocked,
                            NoOfAttempts = model.NoOfAttempts
                        });
                    }

                    var htmlBuilder = new StringBuilder();
                    htmlBuilder.AppendLine("<tr class='info'>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='Username'>" + id + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='full-name'>" +
                                           string.Format("{0} {1} {2}", model.FirstName, model.MiddleInitial,
                                               model.LastName) + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='DateOfBirth'>" +
                                           String.Format("{0:dd MMMM yyyy}", model.DateOfBirth) + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='Email'><a href='mailto:" + model.Email + "'>" + model.Email +
                                           "</a></label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='Mobile'>" + model.Mobile + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='TypeID'>" + model.TypeID + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='NoOfAttempts'>" + model.NoOfAttempts + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for=''>" + (model.Blocked ? "Yes" : "No") + "</label>");
                    htmlBuilder.AppendLine("</td>");

                    htmlBuilder.AppendLine(" <td>");
                    htmlBuilder.AppendLine(
                        " <a class='bttnEditThis  btn btn-sm btn-default pull-left' href='/Accounts/Edit/" + id +
                        "' title='Edit'><i class='glyphicon glyphicon-pencil'>" +
                        "</i><span class='sr-only'>Edit</span></a>");
                    htmlBuilder.AppendLine(
                        " <a class='bttnDetail  btn btn-sm btn-default pull-left' href='/Accounts/Details/" + id +
                        "' title='Details'>" +
                        "<i class='glyphicon glyphicon-list'></i><span class='sr-only'>Edit</span></a>");
                    htmlBuilder.AppendLine(
                        "<a class='bttnDeleteThis  btn btn-sm btn-default pull-right' href='/Accounts/Delete/" + id +
                        "' title='Delete'>" +
                        "<i class='glyphicon glyphicon-trash'></i><span class='sr-only'>Delete</span></a>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("</tr>");

                    return Json(new { result = "OK", html = htmlBuilder.ToString() });
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
            }
            return Edit(id);
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
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new UserServicesClient())
                    {
                        if (!string.IsNullOrEmpty(model.SecurityToken))
                        {
                            if (client.ValidateToken(model.SecurityToken))
                            {
                                if (client.Authenticate(model.Username, model.Password))
                                {
                                    FormsAuthentication.RedirectFromLoginPage(model.Username, model.Remember);
                                }
                                ModelState.AddModelError(string.Empty,
                                    @"The user name or security details provided are incorrect.");
                            }
                            else
                            {
                                ModelState.AddModelError("", @"The security token is invalid or has expired.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", @"Something ate the security token.");
                            Session["SecurityToken"] = client.GenerateToken();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, @"The user name or security details provided are incorrect.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View();
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Manage(string sb, string q, int? p, int ps = 10)
        {
            IEnumerable<UserAccountViewModel> list = null;

            if (sb == "fname")
            {
                using (var client = new UserServicesClient())
                {
                    list = client.ListUsers()
                        .Where(
                            d =>
                                d.FirstName.ToLower().Contains(q.ToLower()) ||
                                d.MiddleInitial.ToLower().Contains(q.ToLower()) ||
                                d.LastName.ToLower().Contains(q.ToLower()))
                        .Select(u => new UserAccountViewModel
                        {
                            Username = u.Username,
                            FirstName = u.FirstName,
                            MiddleInitial = u.MiddleInitial,
                            LastName = u.LastName,
                            Email = u.Email,
                            Mobile = u.Mobile,
                            DateOfBirth = u.DateOfBirth,
                            Address = u.Address,
                            TypeName = u.TypeName,
                            Blocked = u.Blocked,
                            NoOfAttempts = u.NoOfAttempts
                        });
                }
            }
            else if (sb == "username")
            {
                using (var client = new UserServicesClient())
                {
                    list = client.ListUsers().Where(d => d.Username.ToLower().Contains(q.ToLower()))
                        .Select(u => new UserAccountViewModel
                        {
                            Username = u.Username,
                            FirstName = u.FirstName,
                            MiddleInitial = u.MiddleInitial,
                            LastName = u.LastName,
                            Email = u.Email,
                            Mobile = u.Mobile,
                            DateOfBirth = u.DateOfBirth,
                            Address = u.Address,
                            TypeName = u.TypeName,
                            Blocked = u.Blocked,
                            NoOfAttempts = u.NoOfAttempts
                        });
                }
            }
            else
            {
                using (var client = new UserServicesClient())
                {
                    list = client.ListUsers().Select(u => new UserAccountViewModel
                    {
                        Username = u.Username,
                        FirstName = u.FirstName,
                        MiddleInitial = u.MiddleInitial,
                        LastName = u.LastName,
                        Email = u.Email,
                        Mobile = u.Mobile,
                        DateOfBirth = u.DateOfBirth,
                        Address = u.Address,
                        TypeName = u.TypeName,
                        Blocked = u.Blocked,
                        NoOfAttempts = u.NoOfAttempts
                    });
                }
            }
            return View(GetPagedUserList(list, p, ps));
        }

        private static IPagedList<UserAccountViewModel> GetPagedUserList(IEnumerable<UserAccountViewModel> list,
            int? page, int pageSize)
        {
            IPagedList<UserAccountViewModel> pagedList = list.ToPagedList(page ?? 1, pageSize);
            return pagedList;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            var model = new RegisterModel();
            model.Genders = GetGenderList();
            model.Towns = GetTownList();
            return View(model);
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
                    using (var client = new UserServicesClient())
                    {
                        string salt = HashingUtil.GenerateSaltValue();
                        string hashedPassword = HashingUtil.GenerateSaltedHash(model.Password, salt);
                        bool isRegistered = client.Register(new UserView
                        {
                            Username = model.Username,
                            Password = hashedPassword,
                            Salt = salt,
                            FirstName = model.FirstName,
                            MiddleInitial = model.MiddleInitial,
                            LastName = model.LastName,
                            Email = model.Email,
                            Mobile = model.Mobile,
                            DateOfBirth = model.DateOfBirth,
                            Address = model.Address,
                            GenderID = model.GenderID,
                            TownID = model.TownID,
                            TypeID = 1,
                            Blocked = false,
                            NoOfAttempts = 0
                        });

                        if (isRegistered)
                        {
                            if (client.Authenticate(model.Username, model.Password))
                            {
                                FormsAuthentication.SetAuthCookie(model.Username, false);
                                return RedirectToAction("Index", "Home");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, @"Registration failed.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            model.Genders = GetGenderList();
            model.Towns = GetTownList();
            OutputModelStateErrors();
            return View(model);
        }

        private SelectList GetGenderList()
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.Genders(), "ID", "Name");
            }
        }

        private SelectList GetTownList()
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.Towns(), "ID", "Name");
            }
        }

        private SelectList GetTypeList()
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.Types(), "ID", "Name");
            }
        }

        private void OutputModelStateErrors()
        {
            var errors =
                ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => new { x.Key, x.Value.Errors }).ToArray();
            foreach (var error in errors)
            {
                Debug.WriteLine("Key: " + error.Key + " Errors: \t" + error.Errors[0].ErrorMessage);
            }
        }
    }
}