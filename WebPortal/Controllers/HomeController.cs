using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPortal.BankAccountServices;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
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

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                InitialiseAccountInfo();
            }

            return View();
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