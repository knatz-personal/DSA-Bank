using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebPortal.Controllers;
using WebPortal.LoggingServices;
using WebPortal.UserServices;

namespace WebPortal
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (Context.User != null)
            {
                List<RoleView> roleList = new UserServicesClient().GetRoles(Context.User.Identity.Name);

                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, Context.User.Identity.Name));
                foreach (RoleView r in roleList)
                {
                    claims.Add(new Claim(ClaimTypes.Role, r.Name));
                }
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

            var routeData = new RouteData();

            routeData.Values.Add("controller", "Error");

            routeData.Values.Add("action", "Index");

            routeData.Values.Add("exception", exception);

            if (exception.GetType() == typeof (HttpException))
            {
                routeData.Values.Add("statusCode", ((HttpException) exception).GetHttpCode());
            }
            else
            {
                routeData.Values.Add("statusCode", 500);
            }

            Response.TrySkipIisCustomErrors = true;

            IController controller = new ErrorController();

            controller.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));

            Response.End();
        }
    }
}