using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess.Reposiitories.Appointments;

namespace WcfServiceDSABank
{
    public class AppointmentServices : IAppointmentServices
    {
        public IQueryable<AppointmentView> ListAppointments()
        {
            return new AppointmentsRepo().ListAll().OrderBy(a => a.SuggestedDate).Select(apt => new AppointmentView
            {
                ID = apt.ID,
                Description = apt.Description,
                Username = apt.Username,
                Duration = apt.Duration,
                SuggestedDate = apt.SuggestedDate,
                SuggestedTime = apt.SuggestedTime,
                IsAccepted = apt.IsAccepted
            });
        }

        public IQueryable<AppointmentView> FilterAppointmentList(bool? isAccepted, DateTime? start, DateTime? end)
        {
            var repo = new AppointmentsRepo();

            IQueryable<DataAccess.EntityModel.Appointment> list =
                repo.ListAll()
                    .OrderBy(a => a.SuggestedDate)
                    .Where(apt => isAccepted.HasValue ? apt.IsAccepted == isAccepted : apt.IsAccepted == null);

            if (start != null && end != null)
            {
                list = list.Where(apt => apt.SuggestedDate >= start && apt.SuggestedDate <= end);
            }

            return list.Select(apt => new AppointmentView
            {
                ID = apt.ID,
                Description = apt.Description,
                Username = apt.Username,
                Duration = apt.Duration,
                SuggestedDate = apt.SuggestedDate,
                SuggestedTime = apt.SuggestedTime,
                IsAccepted = apt.IsAccepted
            });
        }

        public void Schedule(AppointmentView appointment)
        {
            new AppointmentsRepo().Create(new DataAccess.EntityModel.Appointment
            {
                Username = appointment.Username,
                Description = appointment.Description,
                SuggestedDate = appointment.SuggestedDate,
                SuggestedTime = appointment.SuggestedTime,
                Duration = appointment.Duration,
                IsAccepted = null
            });
        }

        public void Response(AppointmentView appointment)
        {
            new AppointmentsRepo().Update(new DataAccess.EntityModel.Appointment
            {
                ID = appointment.ID,
                Username = appointment.Username,
                Description = appointment.Description,
                SuggestedDate = appointment.SuggestedDate,
                SuggestedTime = appointment.SuggestedTime,
                Duration = appointment.Duration,
                IsAccepted = appointment.IsAccepted
            });
        }

        public void Delete(int id)
        {
            new AppointmentsRepo().Delete(new DataAccess.EntityModel.Appointment
            {
                ID = id
            });
        }
    }
}
