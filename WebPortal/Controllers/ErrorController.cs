using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortal.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int statusCode, Exception exception)
        {
            Response.StatusCode = statusCode;
            ViewBag.Title = Response.Status;
            return View();
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

        public ActionResult BadRequest()
        {
            Response.StatusCode = 403;
            return View();
        }

        public ActionResult ServerError()
        {
            Response.StatusCode = 500;
            return View();
        }
    }
}