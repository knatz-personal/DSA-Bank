using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CommonUtils;
using PagedList;
using WebPortal.BankAccountServices;
using WebPortal.CurrencyConvertorServices;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        public void InitialiseAccountInfo()
        {
            using (var client = new AccountServicesClient())
            {
                List<string> list = client.GetCurrencyList();
                Session["MyAccounts"] = new SelectList(client.ListUserAccounts(User.Identity.Name), "ID", "Name");
                Session["Currencies"] = new SelectList(list, list.Find(a => a.Equals("EUR")));
                Session["AccountTypes"] = new SelectList(client.GetTypes(), "ID", "Name");
            }
        }

        public ActionResult Create()
        {
            InitialiseAccountInfo();
            var model = new AccountCreateModel();
            return Request.IsAjaxRequest()
                ? (ActionResult) PartialView("_CAccount", model)
                : View(model);
        }
        
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
                        double balanceAfterDeduction = 11;

                        if (model.AccFromID > 0)
                        {
                            balanceAfterDeduction = GetBalanceAfterDeduction(model, client);
                        }

                        if (balanceAfterDeduction > 10)
                        {
                            client.Create(model.AccFromID, new AccountView
                            {
                                Name = model.Name,
                                Remarks = model.Remarks,
                                Username = User.Identity.Name,
                                Balance = model.Balance,
                                Currency = model.Currency,
                                TypeID = model.TypeID,
                                DateOpened = DateTime.Now
                            });

                            return Json(new
                            {
                                Result = "OK",
                                Message = "Successfully created a new account."
                            });
                        }
                        ModelState.AddModelError(string.Empty, @"Insufficient account balance");
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, @"Failed to add bank account.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return Request.IsAjaxRequest()
                ? (ActionResult) PartialView("_CAccount", model)
                : View(model);
        }

        private static double GetBalanceAfterDeduction(AccountCreateModel model, AccountServicesClient client)
        {
            double balanceAfterDeduction = 0;

            var converter = new CurrencyConvertorSoapClient("CurrencyConvertorSoap");
            AccountView source = client.GetAccountDetail(model.AccFromID);
            double balanceInEuro =
                converter.ConversionRate(ConverterUtil.StringToEnum<Currency>(source.Currency), Currency.EUR)*
                (double) source.Balance;
            double deductionInEuro =
                converter.ConversionRate(ConverterUtil.StringToEnum<Currency>(model.Currency), Currency.EUR)*
                (double) model.Balance;
            balanceAfterDeduction = Math.Abs(balanceInEuro) - Math.Abs(deductionInEuro);

            return balanceAfterDeduction;
        }

        /*
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


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var client = new AccountServicesClient())
                {
                    client.Delete(id);
                }

                return Json(new
                {
                    Result = "OK"
                });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, @"Failed to remove bank account.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
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
        */

        public ActionResult Details(int id)
        {
            using (var client = new AccountServicesClient())
            {
                AccountView model = client.GetAccountDetail(id);
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
        
        public ActionResult Edit(int id)
        {
            using (var client = new AccountServicesClient())
            {
                AccountView a = client.GetAccountDetail(id);
                return PartialView("_Edit", new AccountEditModel
                {
                    ID = a.ID,
                    Name = a.Name,
                    Remarks = a.Remarks
                });
            }
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(int id, AccountEditModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new AccountServicesClient())
                    {
                        client.Update(new AccountView
                        {
                            ID = model.ID,
                            Name = model.Name,
                            Remarks = model.Remarks
                        });
                        return Json(new {Result = "OK"});
                    }
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, @"An error occurred while attempting to save changes.");
            }
            return PartialView("_Edit", model);
        }
        
        public ActionResult Index(string q, int? p, int ps = 10)
        {
            InitialiseAccountInfo();
            IEnumerable<AccountListItemModel> list = null;
            using (var client = new AccountServicesClient())
            {
                list = client.ListUserAccounts(User.Identity.Name)
                    .Where(s => s.Name.ToLower().Contains((q ?? string.Empty).ToLower()))
                    .Select(t => new AccountListItemModel
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
                ? (ActionResult) PartialView("_PagedList", results.AccountsPagedList)
                : View(results);
        }
    }
}