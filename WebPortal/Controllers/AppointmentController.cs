using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using WebPortal.AppointmentServices;
using WebPortal.LoggingServices;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        // GET: Appointment/Schedule
        public ActionResult Schedule()
        {
            var model = new AppointmentModel();
            model.DurationValues = GetDurationList();
            return View(model);
        }

        // POST: Appointment/Schedule
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Schedule(AppointmentModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        using (var client = new AppointmentServicesClient())
                        {
                            model.Username = User.Identity.Name;
                            model.IsAccepted = null;
                            DateTime dateTime;
                            bool isValidTime = DateTime.TryParseExact(model.SuggestedTime, "h:mm tt",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out dateTime);

                            if (isValidTime)
                            {
                                client.Schedule(new AppointmentView
                                {
                                    Username = model.Username,
                                    SuggestedDate = model.SuggestedDate,
                                    SuggestedTime = dateTime.TimeOfDay,
                                    Duration = model.Duration,
                                    Description = model.Description,
                                    IsAccepted = model.IsAccepted
                                });
                                return Json(new { Result = "OK", Message = "Successfully sent your appointment request." });
                            }
                            ModelState.AddModelError("SuggestedTime", @"Invalid time value.");
                        }
                    }
                    catch
                    {
                        ViewBag.ErrorMessage = "An error occurred communicating over the network.";
                    }
                }
            }
            catch (Exception ev)
            {
                new LogServicesClient().LogError(User.Identity.Name, ev.Message, ev.InnerException.ToString());
            }
            ModelState.AddModelError(string.Empty, @"Failed to schedule an appointment.");
            model.DurationValues = GetDurationList();

            return Request.IsAjaxRequest() ? (ActionResult)PartialView("_Schedule", model) : View("Schedule", model);

        }

        private SelectList GetDurationList()
        {
            var list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "Select", Value = null });
            list.Add(new SelectListItem { Text = "30 mins", Value = "30 mins" });
            list.Add(new SelectListItem { Text = "1 hour", Value = "1 hour" });
            list.Add(new SelectListItem { Text = "1 hour 30 mins", Value = "1 hour 30 mins" });
            return new SelectList(list, "Value", "Text");
        }
    }
}