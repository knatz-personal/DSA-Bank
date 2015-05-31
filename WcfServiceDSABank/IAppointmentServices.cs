using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceDSABank
{
    [ServiceContract]
    public interface IAppointmentServices
    {
        [OperationContract]
        IQueryable<AppointmentView> ListAppointments();

        [OperationContract]
        IQueryable<AppointmentView> FilterAppointmentList(bool? isAccepted, DateTime? start, DateTime? end);

        [OperationContract]
        void Schedule(AppointmentView appointment);

        [OperationContract]
        void Response(AppointmentView appointment);

        [OperationContract]
        void Delete(int id);
    }

    [DataContract]
    public class AppointmentView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime SuggestedDate { get; set; }

        [DataMember]
        public TimeSpan SuggestedTime { get; set; }

        [DataMember]
        public string Duration { get; set; }

        [DataMember]
        public bool? IsAccepted { get; set; }
    }
}