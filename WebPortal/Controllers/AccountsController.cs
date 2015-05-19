using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using WebPortal.BankAccountServices;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        // GET: Balances/Create
        public ActionResult Create()
        {
            using (var client = new AccountServicesClient())
            {
                return View(new AccountCreateModel()
                {
                    Types = GetTypes(),
                    Currencies = GetCurrencies(),
                    MyAccounts = GetMyAccounts(User.Identity.Name)
                });
            }
        }

        // POST: Balances/Create
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(AccountCreateModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new AccountServicesClient())
                    {
                        var a =client.Create(new AccountView()
                        {
                            Name = model.Name,
                            Remarks = model.Remarks,
                            Username = User.Identity.Name,
                            Balance = model.Balance,
                            Currency = model.Currency,
                            TypeID = model.TypeID,
                            DateOpened = DateTime.Now,
                            ExpiryDate = model.ExpiryDate
                        });

                        return Json(new { Result = "OK" , Record = new AccountViewModel()
                        {
                            ID = a.ID,
                            Name = a.Name,
                            Remarks = a.Remarks,
                            Balance = a.Balance,
                            Currency = a.Currency,
                            TypeID = a.TypeID,
                            DateOpened = a.DateOpened,
                            ExpiryDate = a.ExpiryDate
                        }});
                    }
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, @"Failed to add bank account check validation errors for issues.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            model.Types = GetTypes();
            model.Currencies = GetCurrencies();
            model.MyAccounts = GetMyAccounts(User.Identity.Name);
            return View( model);
        }

        // GET: Balances/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new AccountServicesClient())
            {
                var temp = client.GetAccountDetail(id);
                return PartialView("_Delete", new AccountListItemModel()
                {
                    ID = temp.ID,
                    Username = temp.Username,
                    Name = temp.Name,
                    TypeName = temp.TypeName,
                    Remarks = temp.Remarks,
                    Currency = temp.Currency,
                    Balance = temp.Balance,
                    TypeID = temp.TypeID,
                    DateOpened = temp.DateOpened
                });
            }
        }

        // POST: Balances/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var client = new AccountServicesClient())
                {
                    client.Delete(id);
                    return Json(new { Result = "OK", 
                      Message = "Successfully removed account."
                    });
                }
            }
            catch
            {
                return Delete(id);
            }
        }

        // GET: Balances/Details/5
        public ActionResult Details(int id)
        {
            using (var client = new AccountServicesClient())
            {
                var model = client.GetAccountDetail(id);
                return PartialView("_Details", new AccountListItemModel
                {
                    ID = model.ID,
                    TypeID = model.TypeID,
                    TypeName = model.TypeName,
                    DateOpened = model.DateOpened,
                    Username = model.Username,
                    Name = model.Name,
                    Currency = model.Currency,
                    Balance = model.Balance,
                    Remarks = model.Remarks
                });
            }
        }

        // GET: Balances/Edit/5
        public ActionResult Edit(int id)
        {
            using (var client = new AccountServicesClient())
            {
                var a = client.GetAccountDetail(id);
                return PartialView("_Edit", new AccountEditModel()
                {
                    ID = a.ID,
                    ExpiryDate = a.ExpiryDate,
                    Name = a.Name,
                    Remarks = a.Remarks,
                    Types = GetTypes(),
                    Currencies = GetCurrencies()
                });
            }
        }

        // POST: Balances/Edit/5
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(int id, AccountEditModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //new { result = "OK", record = model }
                    return Json("OK");
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
            }
            return Edit(id);
        }

        // GET: Balances
        public ActionResult Index(string q, int? p, int ps = 10)
        {
            IEnumerable<AccountListItemModel> list = null;
            using (var client = new AccountServicesClient())
            {
                  list =  client.ListUserAccounts(User.Identity.Name)
                      .Where(s => s.Name.Contains(q ?? string.Empty) )
                      .Select(t => new AccountListItemModel()
                    {
                        ID = t.ID,
                        TypeID = t.TypeID,
                        TypeName = t.TypeName,
                        DateOpened = t.DateOpened,
                        Username = t.Username,
                        Name = t.Name,
                        Currency = t.Currency,
                        Balance = t.Balance,
                        Remarks = t.Remarks
                    });
           
            }

            var results = new AccountViewModel
            {
                AccountsPagedList = list.ToPagedList(p ?? 1, ps)
            };
            Session["AccountsCurrentResults"] = results;
            return Request.IsAjaxRequest()
            ? (ActionResult)PartialView("_PagedList", results.AccountsPagedList)
            : View(results);
        }
        private SelectList GetCurrencies()
        {
            using (var client = new AccountServicesClient())
            {
                var list = client.GetCurrencyList();
                return new SelectList(list, list.Find(e=>e.Equals("EUR")));
            }
        }

        private SelectList GetTypes()
        {
            using (var client = new AccountServicesClient())
            {
                return new SelectList(client.GetTypes(), "ID", "Name");
            }
        }

        private SelectList GetMyAccounts(string username)
        {
            using (var client = new AccountServicesClient())
            {
                return new SelectList(client.ListUserAccounts(User.Identity.Name), "ID", "Name","EUR");
            }

        }
    }
}