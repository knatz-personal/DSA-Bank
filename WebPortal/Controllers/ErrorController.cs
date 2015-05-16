using System;
using System.Web.Mvc;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public ActionResult Index(int statusCode, Exception exception, bool isAjaxRequest)
        {
            //source=>https://github.com/13daysaweek/Mvc4CustomErrorPage/blob/master/ThirteenDaysAWeek.Mvc4CustomErrorPage.Web/Controllers/ErrorController.cs
            Response.StatusCode = statusCode;
            string message;

            switch (statusCode)
            {
                case 400:
                    message = "Bad request.";
                    break;
                case 401:
                    message = "Access to the requested resource is unauthorized.";
                    break;
                case 403:
                    message = "Access to the requested resource is forbidden. You do not have permission to access it.";
                    break;
                case 404:
                    message = "Requested page or directory not found.";
                    break;
                case 500:
                    message = "An internal server error has occurred.";
                    break;
                default:
                    message = "Requested item not found. ";
                    break;
            }

            // If it's not an AJAX request that triggered this action then just retun the view
            if (!isAjaxRequest)
            {
                var model = new ErrorInfoModel
                {
                    HttpStatusCode = statusCode,
                    StatusDescription = message,
                    Exception = exception
                };

                return View(model);
            }
            // Otherwise, if it was an AJAX request, return an anon type with the message from the exception
            var errorObjet = new {message = exception.Message};
            return Json(errorObjet, JsonRequestBehavior.AllowGet);
        }
    }
}