using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebPortal.BankAccountServices;
using WebPortal.Controllers;
using WebPortal.LoggingServices;
using WebPortal.UserServices;

namespace WebPortal
{
    public class MvcApplication : HttpApplication
    {
        private UserServicesClient _client = new UserServicesClient();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Name;
        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                var item = _client.ReadByUsername(Context.User.Identity.Name);
                Session["FullName"] = string.Format("{0} {1} {2}", item.FirstName, item.MiddleInitial, item.LastName);
                if (Session["Currencies"] == null && Session["MyAccounts"] == null && Session["AccountTypes"] == null)
                {
                    using (var client = new AccountServicesClient())
                    {
                        List<string> list = client.GetCurrencyList();
                        Session["Currencies"] = new SelectList(list, list.Find(a => a.Equals("EUR")));
                        Session["MyAccounts"] = new SelectList(client.ListUserAccounts(User.Identity.Name), "ID", "Name");
                        Session["AccountTypes"] = new SelectList(client.GetTypes(), "ID", "Name");
                    }
                }
            }
        }

        protected void Session_End(Object sender, EventArgs e)
        {

            Session["FullName"] = null;
            Session["Currencies"] = null;
            Session["AccountTypes"] = null;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (Context.User != null)
            {
                List<RoleView> roleList = _client.GetRoles(Context.User.Identity.Name);

                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, Context.User.Identity.Name));
                claims.AddRange(roleList.Select(r => new Claim(ClaimTypes.Role, r.Name)));
                var identity = new ClaimsIdentity(claims, "ApplicationCookie");
                var principal = new ClaimsPrincipal(identity);
                Context.User = principal;
            }
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Exception objErr = exception.GetBaseException();
            string err = "Location: " + Request.Url +
                         " Message: " + objErr.Message;
            using (var client = new LogServicesClient())
            {
                client.LogError(User.Identity.Name, err,
                    "" + objErr.InnerException == string.Empty ? "null" : objErr.InnerException.ToString());
            }

            Server.ClearError();
            Response.TrySkipIisCustomErrors = true;
            int statusCode = 0;

            if (exception.GetType() == typeof(HttpException))
            {
                statusCode = ((HttpException)exception).GetHttpCode();
            }
            else
            {
                statusCode = 500;
            }

            HttpContextWrapper contextWrapper = new HttpContextWrapper(this.Context);

            RouteData routeData = new RouteData();
            routeData.Values.Add("controller", "Error");
            routeData.Values.Add("action", "Index");
            routeData.Values.Add("statusCode", statusCode);
            routeData.Values.Add("exception", exception);
            routeData.Values.Add("isAjaxRequest", contextWrapper.Request.IsAjaxRequest());

            IController controller = new ErrorController();

            RequestContext requestContext = new RequestContext(contextWrapper, routeData);

            controller.Execute(requestContext);
            Response.End();
        }
    }
}