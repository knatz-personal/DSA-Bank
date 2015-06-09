using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebPortal.BankAccountServices;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        private const decimal Tax = (decimal) 0.15;
        private const decimal RemainderAfterTax = (decimal) 0.85;

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

        public ActionResult Index()
        {
            ViewBag.Message = string.Empty;
            if (User.Identity.IsAuthenticated)
            {
                InitialiseAccountInfo();

                try
                {
                    using (var client = new AccountServicesClient())
                    {
                        List<FixedAccountView> fixedtermaccounts = client.GetFixedAccounts(User.Identity.Name);
                        //Term expiry check
                        foreach (FixedAccountView item in fixedtermaccounts)
                        {
                            bool isExpired = (item.ExpiryDate - DateTime.Now).TotalDays < 0;
                            if (isExpired && item.IsExpired == false)
                            {
                                item.IsExpired = true;
                                decimal bal = item.Balance;
                                decimal untaxedInterest = GetUnTaxedInterest(item);
                                item.MaturityAmount = bal + untaxedInterest;
                                item.IncomeTaxDeduction = untaxedInterest * Tax;
                                item.AccumulatedInterest = untaxedInterest * RemainderAfterTax;
                                client.UpdateFixedAccount(item);

                                ViewBag.Message += "<p><h2>The fixed term for account number " + item.ID + " has expired. Go to services to renew or transfer funds.</h2></p>";

                            }
                        }
                    }
                }
                catch
                {
                    ViewBag.ErrorMessage = "An error occurred communicating over the network.";
                }
            }

            return View();
        }

        private decimal GetUnTaxedInterest(FixedAccountView item)
        {
            return ((item.Balance*item.InterestRate)/GetRealDuration(item.DurationID));
        }

        public int GetRealDuration(int duration)
        {
            int result;

            if (duration == 2)
            {
                //THREE Months
                result = 3/12;
            }
            else if (duration == 3)
            {
                //ONE Year
                result = 6/12;
            }
            else if (duration == 4)
            {
                //ONE Year
                result = 12/12;
            }
            else
            {
                result = 1/12;
            }

            return result;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}