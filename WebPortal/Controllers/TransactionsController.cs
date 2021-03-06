﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;
using CommonUtils;
using PagedList;
using WebPortal.BankAccountServices;
using WebPortal.Helpers;
using WebPortal.Models;
using WebPortal.TransactionServices;
using FixedAccountView = WebPortal.TransactionServices.FixedAccountView;

namespace WebPortal.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        public ActionResult DetailReport(int id)
        {
            try
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
                    new StreamReader(Server.MapPath("~/Content/paper.bootstrap.min.css"),
                        Encoding.UTF8))
                {
                    css = streamReader.ReadToEnd();
                }
                MemoryStream outStream = PrintUtil.CreatePDF(html, css);

                return File(outStream.ToArray(), "application/pdf");
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(int id)
        {
            try
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
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Index(int? a, string st, string ed, int? p, int ps = 15)
        {
            DateTime start;
            DateTime end;
            bool isValidStartDate = DateTime.TryParse(st ?? string.Empty, out start);
            bool isValidEndDate = DateTime.TryParse(ed ?? string.Empty, out end);
            IEnumerable<TransactionListItemModel> list;
            try
            {
                using (var client = new TransactionServicesClient())
                {
                    IEnumerable<TransactionView> temp = null;
                    if (a != null && (isValidStartDate && isValidEndDate))
                    {
                        temp = client.FilterTransactions(User.Identity.Name, (int)a, SortOrder.Descending, start, end);
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
                    TransactionsPagedList = list.ToPagedList(p ?? 1, ps)
                };
                Session["TransactionsCurrentResults"] = results;
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }
            return Request.IsAjaxRequest()
                ? (ActionResult)PartialView("_PagedList", ((TransactionViewModel)Session["TransactionsCurrentResults"]).TransactionsPagedList)
                : View(Session["TransactionsCurrentResults"]);
        }

        public ActionResult Report()
        {
            var model = (TransactionViewModel)Session["TransactionsCurrentResults"];
            model.TransactionsList = model.TransactionsPagedList.AsEnumerable();
            return View(model);
        }

        [HttpGet]
        public ActionResult Deposit()
        {
            var model = new DepositModel();
            try
            {

                using (var client = new AccountServicesClient())
                {
                    var temp = client.GetFixedAccounts(User.Identity.Name);
                    var temp2 = client.ListUserAccounts(User.Identity.Name).Where(o => o.TypeID != 3);
                    model.MyTermAccounts = new SelectList(temp, "ID", "Name");
                    model.TermsList = new SelectList(client.GetFixedTerms(), "ID", "Name");
                    model.MyAccounts = new SelectList(temp2, "ID", "Name");
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "An error occurred communicating over the network.";
            }

            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Deposit(DepositModel model)
        {
            try
            {
                int months = GetDurationInMonths(model.Duration);

                try
                {
                    using (var clientAccount = new AccountServicesClient())
                    {
                        var fixedAccount = clientAccount.GetFixedAccount(model.AccountToID);

                        if (fixedAccount != null && (fixedAccount.IsExpired == true && fixedAccount.MaturityAmount > 0))
                        {
                            return RenewFixedTermAccount(model, fixedAccount, months);
                        }
                        if (ModelState.IsValid)
                        {
                            return InitialTermDeposit(model, months);
                        }
                    }
                }
                catch
                {
                    ModelState.AddModelError(string.Empty, @"An error occurred communicating over the network.");
                }
            }
            catch (Exception conn)
            {
                ModelState.AddModelError(string.Empty,
                    @"There was an error completing the transaction, contact the administrator for help. Note: You can only renew accounts after they expire.");
                ModelState.AddModelError(string.Empty, conn.Message);
            }

            try
            {
                using (var client = new AccountServicesClient())
                {
                    model.MyTermAccounts = new SelectList(client.GetFixedAccounts(User.Identity.Name), "ID", "Name");
                    model.TermsList = new SelectList(client.GetFixedTerms(), "ID", "Name");
                    model.MyAccounts = new SelectList(client.ListUserAccounts(User.Identity.Name).Where(o => o.TypeID != 3), "ID", "Name");
                }
            }
            catch (Exception conn)
            {
                ModelState.AddModelError(string.Empty,
                    @"An error occurred communicating over the network.");
            }

            return Request.IsAjaxRequest() ? (ActionResult)PartialView("_Deposit", model) : View("Deposit", model);
        }

        private ActionResult RenewFixedTermAccount(DepositModel model, AccountView fixedAccount, int months)
        {
            using (var client = new TransactionServicesClient())
            {
                var accountInfo = new FixedAccountView()
                {
                    AccumulatedInterest = fixedAccount.AccumulatedInterest,
                    IncomeTaxDeduction = fixedAccount.IncomeTaxDeduction,
                    MaturityAmount = fixedAccount.MaturityAmount,
                    Balance = (decimal)fixedAccount.MaturityAmount,
                    ID = model.AccountToID,
                    DurationID = model.Duration,
                    ExpiryDate = DateTime.Now.AddMonths(months),
                    IsExpired = false
                };

                var transactionInfo = new TransactionView()
                {
                    DateIssued = DateTime.Now,
                    TypeID = 1,
                    Remarks = model.Remarks,
                    AccountFromID = fixedAccount.ID,
                    AccountToID = model.AccountToID,
                    Amount = (decimal)fixedAccount.MaturityAmount,
                    Currency = model.Currency
                };

                //Create method to effect a term deposit
                client.TermDeposit(accountInfo, transactionInfo);

                return Json(new { Result = "OK", Message = "Successfully renewed fixed term account" });
            }
        }

        private ActionResult InitialTermDeposit(DepositModel model, int months)
        {
            using (var client = new TransactionServicesClient())
            {
                var accountInfo = new FixedAccountView()
                {
                    AccumulatedInterest = 0,
                    IncomeTaxDeduction = 0,
                    MaturityAmount = 0,
                    ID = model.AccountToID,
                    DurationID = model.Duration,
                    ExpiryDate = DateTime.Now.AddMonths(months),
                    IsExpired = false
                };

                var transactionInfo = new TransactionView()
                {
                    DateIssued = DateTime.Now,
                    TypeID = 1,
                    Remarks = model.Remarks,
                    AccountFromID = model.AccountFromID,
                    AccountToID = model.AccountToID,
                    Amount = model.Amount,
                    Currency = model.Currency
                };

                //Create method to effect a term deposit
                client.TermDeposit(accountInfo, transactionInfo);

                return Json(new { Result = "OK", Message = "Successfully transfered funds" });
            }
        }

        private int GetDurationInMonths(int duration)
        {
            int result;

            if (duration == 2)
            {
                //THREE Months
                result = 3;
            }
            else if (duration == 3)
            {
                //Six months
                result = 6;
            }
            else if (duration == 4)
            {
                //ONE Year
                result = 12;
            }
            else
            {
                result = 1;
            }

            return result;
        }

        [HttpGet]
        [ActionName("Local Transfer")]
        public ActionResult TransferOther()
        {
            return View("TransferOther", new TransferOtherModel());
        }

        [ValidateAntiForgeryToken]
        [ActionName("Local Transfer")]
        [HttpPost]
        public ActionResult TransferOther(TransferOtherModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        using (var client = new TransactionServicesClient())
                        {
                            client.LocalTransfer(new TransactionView()
                            {
                                DateIssued = DateTime.Now,
                                AccountFromID = model.AccountFromID,
                                AccountToID = model.AccountToID,
                                Amount = model.Amount,
                                Currency = model.Currency,
                                Remarks = model.Remarks,
                                TypeID = 3
                            });

                            return Json(new { Result = "OK", Message = "Successfully transfered funds" });
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
                ModelState.AddModelError(string.Empty,
                    @"There was an error completing the transaction, contact the administrator for help.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return Request.IsAjaxRequest() ? (ActionResult)PartialView("_TOther", model) : View("TransferOther", model);
        }

        [HttpGet]
        [ActionName("Personal Transfer")]
        public ActionResult TransferOwn()
        {
            return View("TransferOwn", new TransferOwnModel());
        }

        [ValidateAntiForgeryToken]
        [ActionName("Personal Transfer")]
        [HttpPost]
        public ActionResult TransferOwn(TransferOwnModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        using (var clientAccount = new AccountServicesClient())
                        {
                            var fixedAccount = clientAccount.GetFixedAccount((int)model.AccountFromID);
                            using (var client = new TransactionServicesClient())
                            {
                                if (fixedAccount != null && (fixedAccount.IsExpired == true && fixedAccount.MaturityAmount > 0))
                                {
                                    client.PersonalTransfer(new TransactionView()
                                   {
                                       DateIssued = DateTime.Now,
                                       AccountFromID = model.AccountFromID,
                                       AccountToID = model.AccountToID,
                                       Amount = (decimal)fixedAccount.MaturityAmount,
                                       Currency = fixedAccount.Currency,
                                       Remarks = model.Remarks,
                                       TypeID = 2
                                   });
                                    return Json(new { Result = "OK", Message = "Successfully transfered funds" });
                                }
                                
                                client.PersonalTransfer(new TransactionView()
                                {
                                    DateIssued = DateTime.Now,
                                    AccountFromID = model.AccountFromID,
                                    AccountToID = model.AccountToID,
                                    Amount = model.Amount,
                                    Currency = model.Currency,
                                    Remarks = model.Remarks,
                                    TypeID = 2
                                });

                                return Json(new { Result = "OK", Message = "Successfully transfered funds" });
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
                ModelState.AddModelError(string.Empty,
                    @"There was an error completing the transaction, contact the administrator for help.");
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return Request.IsAjaxRequest() ? (ActionResult)PartialView("_TOwn", model) : View("TransferOwn", model);

        }

    }
}