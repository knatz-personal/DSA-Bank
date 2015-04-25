using System;
using System.CodeDom.Compiler;
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
        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            using (var client = new TransactionServicesClient())
            {
                var t = client.GetTransactionDetails(id);
                return PartialView("_Details", new TransactionDetailModel()
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

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Index(int? a, DateTime? st, DateTime? ed, int? p, int ps = 10)
        {
            IEnumerable<TransactionListItemModel> list = null;
            using (var client = new TransactionServicesClient())
            {
                list =
                   client.ListUserTransactions(User.Identity.Name)
                   .Where(f => ((f.AccountFromID == a || f.AccountToID == a) && (st <= f.DateIssued && f.DateIssued >= ed)) || (f.AccountFromID == a || f.AccountToID == a) || (st <= f.DateIssued && f.DateIssued >= ed))
                   .Select(t => new TransactionListItemModel
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
            var results = new TransactionViewModel()
            {
                TransactionsPagedList = list.ToPagedList(p ?? 1, ps),
                MyAccounts = GetMyAccounts(User.Identity.Name)
            };
            Session["CurrentResults"] = results;
            return View(results);
        }

        public ActionResult Report()
        {
            var model = (TransactionViewModel)Session["CurrentResults"];
            model.TransactionsList = model.TransactionsPagedList.AsEnumerable();
            return View(model);
        }

        private SelectList GetMyAccounts(string username)
        {
            using (var client = new AccountServicesClient())
            {
                return new SelectList(client.ListUserAccounts(User.Identity.Name), "ID", "Name");
            }
        }

    }
}