using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using WebPortal.BankAccountServices;
using WebPortal.BankTransactionServices;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        public ActionResult Details(int id)
        {
            using (var client = new TransactionServicesClient())
            {
                TransactionView t = client.GetTransactionDetails(id);
                return PartialView("_Details", new TransactionDetailModel
                {
                    ID = t.ID,
                    DateIssued = t.DateIssued,
                    TypeName = t.TypeName,
                    AccountFromID = t.AccountFromID,
                    AccountToID = t.AccountToID,
                    Amount = t.Amount,
                    Currency = t.Currency,
                    Remarks = t.Remarks
                });
            }
        }

        public ActionResult Index(int? a, string st, string ed, int? p, int ps = 15)
        {
            DateTime start;
            DateTime end;
            bool isValidStartDate = DateTime.TryParse(st ?? string.Empty, out start);
            bool isValidEndDate = DateTime.TryParse(ed ?? string.Empty, out end);
            IEnumerable<TransactionListItemModel> list = null;
            using (var client = new TransactionServicesClient())
            {
                IEnumerable<TransactionView> temp = null;
                if (a != null && (isValidStartDate || isValidEndDate))
                {
                    temp =
                        client.ListUserTransactions(User.Identity.Name)
                            .Where(f => ((f.AccountFromID == a || f.AccountToID == a)
                                         && (f.DateIssued > start && f.DateIssued < end.Date)));
                }
                else
                {
                    temp =
                        client.ListUserTransactions(User.Identity.Name)
                            .Where(f => (f.AccountFromID == a || f.AccountToID == a));
                }

                list = temp.Select(t => new TransactionListItemModel
                {
                    ID = t.ID,
                    DateIssued = t.DateIssued,
                    TypeID = t.TypeID,
                    TypeName = t.TypeName,
                    AccountFromID = t.AccountFromID,
                    AccountToID = t.AccountToID,
                    Amount = t.Amount,
                    Currency = t.Currency,
                    Remarks = t.Remarks
                });
            }


            var results = new TransactionViewModel
            {
                TransactionsPagedList = list.ToPagedList(p ?? 1, ps),
                MyAccounts = GetMyAccounts(User.Identity.Name)
            };
            Session["TransactionsCurrentResults"] = results;
            return Request.IsAjaxRequest()
            ? (ActionResult)PartialView("_PagedList", results.TransactionsPagedList)
            : View(results);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View(new TransactionModel()
            {
                Types = GetTransactionTypes(),
                Currencies =GetCurrencies(),
                MyAccounts = GetMyAccounts(User.Identity.Name),
                UtilityAccounts = GetMyUtilityAccountss(User.Identity.Name)
            });
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult New(TransactionModel model)
        {
            try
            {
                return RedirectToAction("Index", "Transactions");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty,
                    "There was an error paying the bill, contact the administrator for help.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(model);
        }

        public ActionResult Report()
        {
            var model = (TransactionViewModel)Session["TransactionsCurrentResults"];
            model.TransactionsList = model.TransactionsPagedList.AsEnumerable();
            return View(model);
        }

        private SelectList GetCurrencies()
        {
            using (var client = new AccountServicesClient())
            {
                var list = client.GetCurrencyList();
                return new SelectList(list, list.Find(e => e.Equals("EUR")));
            }
        }

        private SelectList GetMyAccounts(string username)
        {
            using (var client = new AccountServicesClient())
            {
                return new SelectList(client.ListUserAccounts(User.Identity.Name), "ID", "Name");
            }
        }
        private IEnumerable<SelectListItem> GetMyUtilityAccountss(string username)
        {
            using (var client = new AccountServicesClient())
            {
                return new SelectList(client.ListUserUtilityAccounts(User.Identity.Name), "ID", "Name");
            }
        }

        private SelectList GetTransactionTypes()
        {
            using (var client = new TransactionServicesClient())
            {
                return new SelectList(client.GetTransactionTypes(), "ID", "Name");
            }
        }
    }
}