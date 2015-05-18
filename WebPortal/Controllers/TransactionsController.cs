using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CommonUtils;
using PagedList;
using WebPortal.BankAccountServices;
using WebPortal.Helpers;
using WebPortal.Models;
using WebPortal.TransactionServices;

namespace WebPortal.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        public FileResult DetailReport(int id)
        {
            string html;
            using (var client = new TransactionServicesClient())
            {
                TransactionView t = client.GetTransactionDetails(id);
                html = this.RenderView("DetailReport", new TransactionDetailModel
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
            string css;
            using (var streamReader =
                new StreamReader(Server.MapPath("~/Content/paper-bootstrap-theme.css"),
                    Encoding.UTF8))
            {
                css = streamReader.ReadToEnd();
            }
            MemoryStream outStream = PrintUtil.CreatePDF(html, css);

            return File(outStream.ToArray(), "application/pdf");
        }

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
            IEnumerable<TransactionListItemModel> list;
            using (var client = new TransactionServicesClient())
            {
                IEnumerable<TransactionView> temp = null;
                if (a != null && (isValidStartDate && isValidEndDate))
                {
                    temp = client.FilterTransactions(User.Identity.Name, (int) a, SortOrder.Descending, start, end);
                }
                else
                {
                    temp =
                        client.ListUserTransactions(User.Identity.Name)
                            .Where(ua => ua.AccountFromID == a || ua.AccountToID == a);
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
                AccountToListID = a,
                StartDate = start,
                EndDate = end,
                TransactionsPagedList = list.ToPagedList(p ?? 1, ps),
                MyAccounts = GetMyAccounts(User.Identity.Name)
            };
            Session["TransactionsCurrentResults"] = results;
            return Request.IsAjaxRequest()
                ? (ActionResult) PartialView("_PagedList", results.TransactionsPagedList)
                : View(results);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View(new TransferOwnModel
            {
                Types = GetTransactionTypes(),
                Currencies = GetCurrencies(),
                MyAccounts = GetMyAccounts(User.Identity.Name),
                UtilityAccounts = GetMyUtilityAccountss(User.Identity.Name)
            });
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult New(TransferOwnModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.DateIssued = DateTime.Now;
                    switch (model.TypeID)
                    {
                        case 1:
                            //Deposit
                            break;
                        case 2:
                            //Bill Payment
                            break;
                        case 3:
                            //Transfer To Mine
                            using (var client = new TransactionServicesClient())
                            {
                                client.Create(new TransactionView()
                                {
                                    DateIssued = model.DateIssued,
                                    TypeID = model.TypeID,
                                    Remarks = model.Remarks,
                                    AccountFromID = model.AccountFromID,
                                    AccountToID = model.AccountToID,
                                    Amount = model.Amount,
                                    Currency = model.Currency
                                });
                            }
                            break;
                        case 4:
                            //Transfer To Other
                            break;
                        default:
                            ModelState.AddModelError(string.Empty,@"Invalid transaction type value.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty,
                    "There was an error completing the transaction, contact the administrator for help.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return New();
        }
        
        public ActionResult Report()
        {
            var model = (TransactionViewModel) Session["TransactionsCurrentResults"];
            model.TransactionsList = model.TransactionsPagedList.AsEnumerable();
            return View(model);
        }

        private SelectList GetCurrencies()
        {
            using (var client = new AccountServicesClient())
            {
                List<string> list = client.GetCurrencyList();
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

        private SelectList GetMyUtilityAccountss(string username)
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