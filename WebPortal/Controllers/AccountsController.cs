using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortal.BankAccountServices;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        // GET: Balances
        public ActionResult Index()
        {
            using (var client = new BankAccountServicesClient())
            {
                IEnumerable<BankAccountViewModel> list =
                   client.ListUserAccounts(User.Identity.Name).Select(t => new BankAccountViewModel
                   {
                       ID = t.ID,
                       TypeID = t.TypeID,
                       DateOpened = t.DateOpened,
                       Username = t.Username,
                       Name = t.Name,
                       ExpiryDate = t.ExpiryDate,
                       Currency = t.Currency,
                       Balance = t.Balance,
                       Remarks = t.Remarks
                   }); 
                return View(list);
            }
        }

        // GET: Balances/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Balances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Balances/Create
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

        // GET: Balances/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Balances/Edit/5
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

        // GET: Balances/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Balances/Delete/5
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
