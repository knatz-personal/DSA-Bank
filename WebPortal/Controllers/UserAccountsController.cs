using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;
using WebPortal.Models;
using WebPortal.UserServices;

namespace WebPortal.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UserAccountsController : Controller
    {
        private string password;
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
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        public PartialViewResult Details(string id)
        {
            using (var client = new UserServicesClient())
            {
                UserView u = client.ReadByUsername(id);
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
                    NoOfAttempts = u.NoOfAttempts
                });
            }
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(string id,UserAccountViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new UserServicesClient())
                    {
                        client.Update(new UserView()
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
                    htmlBuilder.AppendLine("<label for='Username'>"+id+"</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");  
                    htmlBuilder.AppendLine("<label for='full-name'>"+string.Format("{0} {1} {2}", model.FirstName, model.MiddleInitial, model.LastName)+"</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='DateOfBirth'>" + String.Format("{0:dd MMMM yyyy}", model.DateOfBirth) + "</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");
                    htmlBuilder.AppendLine("<label for='Email'><a href='mailto:" + model.Email + "'>" + model.Email + "</a></label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");  
                    htmlBuilder.AppendLine("<label for='Mobile'>"+model.Mobile+"</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");  
                    htmlBuilder.AppendLine("<label for='TypeID'>"+model.TypeID+"</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");  
                    htmlBuilder.AppendLine("<label for='NoOfAttempts'>"+model.NoOfAttempts+"</label>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("<td>");  
                    htmlBuilder.AppendLine("<label for=''>"+(model.Blocked? "Yes" : "No")+"</label>");
                    htmlBuilder.AppendLine("</td>");

                    htmlBuilder.AppendLine(" <td>");
                    htmlBuilder.AppendLine(" <a class='bttnEditThis' href='/Accounts/Edit/" + id + "' title='Edit'><i class='glyphicon glyphicon-pencil'>" +
                                           "</i><span class='sr-only'>Edit</span></a> |");
                    htmlBuilder.AppendLine(" <a class='bttnDetail' href='/Accounts/Details/" + id + "' title='Details'>" +
                                           "<i class='glyphicon glyphicon-list'></i><span class='sr-only'>Edit</span></a> |");
                    htmlBuilder.AppendLine("<a class='bttnDeleteThis'href='/Accounts/Delete/" + id + "' title='Delete'>" +
                                           "<i class='glyphicon glyphicon-trash'></i><span class='sr-only'>Delete</span></a>");
                    htmlBuilder.AppendLine("</td>");
                    htmlBuilder.AppendLine("</tr>");
                   
                    return Json(new { result = "OK", html = htmlBuilder.ToString()});
                }

                ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
                return PartialView("_Edit", model);
            }
            catch
            {
                ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
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
                        ModelState.AddModelError(string.Empty,
                            @"The user name or security details provided are incorrect.");
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
            using (var client = new UserServicesClient())
            {
                IEnumerable<UserAccountViewModel> list = client.ListUsers().Select(u => new UserAccountViewModel
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
                    
                }
                ModelState.AddModelError(string.Empty, @"Registration failed.");
                return Register();
            }
            catch
            {
                return Register();
            }
        }
    }
}