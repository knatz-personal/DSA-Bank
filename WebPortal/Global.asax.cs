using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebPortal.LoggingServices;
using WebPortal.UserServices;

namespace WebPortal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            try
            {
                if (Context.User != null)
                {
                    List<RoleView> usersRole = new UserServicesClient().GetRoles(Context.User.Identity.Name);
                    var roles = new string[usersRole.Count()];
                    int counter = 0;
                    foreach (RoleView r in usersRole)
                    {
                        roles[counter] = r.Name;
                        counter++;
                    }

                    var gp = new GenericPrincipal(Context.User.Identity, roles);
                    Context.User = gp;
                }
            }
            catch (Exception ex)
            {
                 FormsAuthentication.SignOut();
                 using (var client = new LogServicesClient())
                 {
                     client.LogError(User.Identity.Name, ex.Message, "" + ex.InnerException == string.Empty ? "null" : ex.InnerException.ToString());
                 }
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception objErr = Server.GetLastError().GetBaseException();
            string err = "Location: " + Request.Url +
                         " Message: " + objErr.Message;
            using (var client = new LogServicesClient())
            {
                client.LogError(User.Identity.Name, err, "" + objErr.InnerException == string.Empty ? "null" : objErr.InnerException.ToString());
            }
        }

    }
}
