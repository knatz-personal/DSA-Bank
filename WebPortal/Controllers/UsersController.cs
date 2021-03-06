﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CommonUtils;
using Microsoft.Owin.Security;
using PagedList;
using WebPortal.BankAccountServices;
using WebPortal.Models;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UsersController : Controller
    {
        public ActionResult Delete(string id)
        {
            try
            {
                using (var client = new UserServicesClient())
                {
                    UserView u = client.ReadByUsername(id);
                    return PartialView("_Delete", new UserListItemModel()
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
                        Blocked = u.Blocked,
                        NoOfAttempts = u.NoOfAttempts
                    });
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Delete(string id, UserAccountViewModel model)
        {
            try
            {
                try
                {
                    using (var client = new UserServicesClient())
                    {
                        client.Delete(id);
                    }
                }
                catch
                {
                    throw new Exception("An error occurred communicating over the network.");
                }
                return Json("OK");
            }
            catch (Exception e)
            {
                return Json(new { Result = "OK", e.Message });
            }
        }

        public ActionResult Details(string id)
        {
            try
            {
                using (var client = new UserServicesClient())
                {
                    UserView u = client.ReadByUsername(id);
                    if (u.TownID != null && u.GenderID != null)
                    {
                        return PartialView("_Details", new UserListItemModel
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
                            UserRoles = new SelectList(u.Roles, "ID", "Name"),
                            Blocked = u.Blocked,
                            NoOfAttempts = u.NoOfAttempts
                        });
                    }
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        public ActionResult Edit(string id)
        {
            try
            {
                using (var client = new UserServicesClient())
                {
                    UserView u = client.ReadByUsername(id);
                    return PartialView("_Edit", new UserListItemModel
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
                        Username = u.Username,
                        Blocked = u.Blocked,
                        NoOfAttempts = u.NoOfAttempts,
                        Genders = GetGenderList(),
                        Towns = GetTownList()
                    });
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(string id, UserListItemModel model)
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
                    htmlBuilder.AppendLine("<label for='NoOfAttempts'>" + model.NoOfAttempts + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for=''>" + (model.Blocked ? "Yes" : "No") + "</label>");
                    htmlBuilder.AppendLine("</td>");

                    htmlBuilder.AppendLine(" <td>");
                    htmlBuilder.AppendLine(" <a class='bttnAssignThis  btn btn-sm btn-default pull-left' href='/Accounts/Role/" + id +
                     "' title='Role'><i class='glyphicon glyphicon-lock'>" + "</i><span class='sr-only'>Role</span></a>");
                    htmlBuilder.AppendLine(
                        " <a class='bttnEditThis  btn btn-sm btn-default pull-left' href='/Accounts/Edit/" + id +
                        "' title='Edit'><i class='glyphicon glyphicon-pencil'>" +
                        "</i><span class='sr-only'>Role</span></a>");
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

        public ActionResult Index(string sb, string q, int? p, int ps = 10)
        {
            IEnumerable<UserListItemModel> list = null;

            try
            {
                if (sb == "fname" && !string.IsNullOrEmpty(q))
                {
                    using (var client = new UserServicesClient())
                    {
                        list = client.ListUsers()
                            .Where(
                                d =>
                                    d.FirstName.ToLower().Contains(q.ToLower()) ||
                                     d.MiddleInitial != null && d.MiddleInitial.ToLower().Contains(q.ToLower()) ||
                                    d.LastName.ToLower().Contains(q.ToLower())).Select(u => new UserListItemModel
                            {
                                Username = u.Username,
                                FirstName = u.FirstName,
                                MiddleInitial = u.MiddleInitial,
                                LastName = u.LastName,
                                Email = u.Email,
                                Mobile = u.Mobile,
                                DateOfBirth = u.DateOfBirth,
                                Address = u.Address,
                                Blocked = u.Blocked,
                                NoOfAttempts = u.NoOfAttempts
                            });
                    }
                }
                else if (sb == "username" && !string.IsNullOrEmpty(q))
                {
                    using (var client = new UserServicesClient())
                    {
                        list = client.ListUsers().Where(d => d.Username.ToLower().Contains(q.ToLower()))
                            .Select(u => new UserListItemModel
                            {
                                Username = u.Username,
                                FirstName = u.FirstName,
                                MiddleInitial = u.MiddleInitial,
                                LastName = u.LastName,
                                Email = u.Email,
                                Mobile = u.Mobile,
                                DateOfBirth = u.DateOfBirth,
                                Address = u.Address,
                                Blocked = u.Blocked,
                                NoOfAttempts = u.NoOfAttempts
                            });
                    }
                }
                else
                {
                    using (var client = new UserServicesClient())
                    {
                        list = client.ListUsers().Select(u => new UserListItemModel
                        {
                            Username = u.Username,
                            FirstName = u.FirstName,
                            MiddleInitial = u.MiddleInitial,
                            LastName = u.LastName,
                            Email = u.Email,
                            Mobile = u.Mobile,
                            DateOfBirth = u.DateOfBirth,
                            Address = u.Address,
                            Blocked = u.Blocked,
                            NoOfAttempts = u.NoOfAttempts
                        });
                    }
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            var model = new UserAccountViewModel()
            {
                UsersPagedList = GetPagedUserList(list, p, ps)
            };
            return Request.IsAjaxRequest()
                ? (ActionResult)PartialView("_PagedList", model.UsersPagedList) : View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }
            throw new HttpException(403, "Insufficient authorization");
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
                    try
                    {
                        using (var client = new UserServicesClient())
                        {
                            if (!string.IsNullOrEmpty(model.SecurityToken))
                            {
                                if (client.ValidateToken(model.SecurityToken))
                                {
                                    if (client.Authenticate(model.Username, model.Password))
                                    {
                                        var identity = new ClaimsIdentity(new[]
                                    {
                                        new Claim(ClaimTypes.Name, model.Username)
                                    }, "ApplicationCookie");

                                        HttpContext.GetOwinContext()
                                            .Authentication.SignIn(
                                                new AuthenticationProperties { IsPersistent = model.Remember },
                                                identity);

                                        return RedirectToAction("Index", "Home");
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
                    catch
                    {
                        throw new Exception("An error occurred communicating over the network.");
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
            Request.GetOwinContext().Authentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            try
            {
                var model = new RegisterModel();
                model.Genders = GetGenderList();
                model.Towns = GetTownList();
                return View(model);
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
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
                    try
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
                    catch
                    {
                        throw new Exception("An error occurred communicating over the network.");
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
            //OutputModelStateErrors();
            return View(model);
        }

        public ActionResult Role(string id)
        {
            try
            {
                using (var client = new UserServicesClient())
                {
                    UserView u = client.ReadByUsername(id);
                    return PartialView("_Role", new RoleModel()
                    {
                        Username = u.Username,
                        Roles = GetRoleList(),
                        UserRoles = GetCurrentUserRoles(u.Username)
                    });
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Role(string id, RoleModel model)
        {
            try
            {
                if (id != string.Empty)
                {
                    if (model.Action == true)
                    {
                        try
                        {
                            using (var client = new UserServicesClient())
                            {
                                client.AllocateRole(id, model.RoleId);
                            }
                        }
                        catch
                        {
                            throw new Exception("An error occurred communicating over the network.");
                        }
                    }
                    if (model.Action == false)
                    {
                        var temp = GetCurrentUserRoles(id);

                        if (temp.SingleOrDefault(ir => ir.Value == model.RoleId + "") != null)
                        {
                            if (temp.Count() > 1)
                            {
                                try
                                {
                                    using (var client = new UserServicesClient())
                                    {
                                        client.DeallocateRole(id, model.RoleId);
                                    }
                                }
                                catch
                                {
                                    throw new Exception("An error occurred communicating over the network.");
                                }
                            }
                            else
                            {
                                ModelState.AddModelError(string.Empty, @"A user must have at least one role.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, @"The user does not have this role.");
                        }

                    }
                    var m = new RoleModel
                    {
                        Action = null,
                        Username = id,
                        Roles = GetRoleList(),
                        UserRoles = GetCurrentUserRoles(id)
                    };

                    if (Request.IsAjaxRequest())
                    {
                        return PartialView("_Role", m);
                    }
                    return View("Role", m);
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
            }
            var m2 = new RoleModel()
            {
                Action = null,
                Username = id,
                Roles = GetRoleList(),
                UserRoles = GetCurrentUserRoles(id)
            };
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Role", m2);
            }
            return View("Role", m2);
        }
        private static IPagedList<UserListItemModel> GetPagedUserList(IEnumerable<UserListItemModel> list,
            int? page, int pageSize)
        {
            IPagedList<UserListItemModel> pagedList = list.ToPagedList(page ?? 1, pageSize);
            return pagedList;
        }

        private IEnumerable<SelectListItem> GetCurrentUserRoles(string username)
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.GetRoles(username), "ID", "Name");
            }
        }

        private SelectList GetGenderList()
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.Genders(), "ID", "Name");
            }
        }

        private SelectList GetRoleList()
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.ListRoles(), "ID", "Name");
            }
        }

        private SelectList GetTownList()
        {
            using (var client = new UserServicesClient())
            {
                return new SelectList(client.Towns(), "ID", "Name");
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