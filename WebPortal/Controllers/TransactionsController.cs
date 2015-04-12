using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebPortal.BankTransactionServices;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        // GET: Transaction
        public ActionResult Index()
        {
            using (var client = new TransactionServicesClient())
            {
                IEnumerable<TransactionViewModel> list =
                   client.ListUserTransactions(User.Identity.Name).Select(t => new TransactionViewModel
                   {
                       ID = t.ID,
                       DateIssued = t.DateIssued,
                       TypeID = t.TypeID,
                       AccountFromID = t.AccountFromID,
                       AccountToID = t.AccountToID,
                       Amount = t.Amount,
                       Currency = t.Currency,
                       Remarks = t.Remarks
                   });

                return View(list);
            }
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
    }
}