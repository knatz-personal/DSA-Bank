using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DSABusinessServices.Log
{
    [ServiceContract]
    public interface ILogServices
    {
        [OperationContract]
        void DeleteError(int id);

        [OperationContract]
        void DeleteEvent(int id);

        [OperationContract]
        IQueryable<ErrorView> ListErrors();

        [OperationContract]
        IQueryable<EventView> ListEvents();

        [OperationContract]
        void LogError(string username, string message, string innerException);

        [OperationContract]
        void LogEvent(string username, string message, string source);
    }

    [DataContract]
    public class ErrorView
    {
        [DataMember]
        public DateTime? DateTriggered { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string InnerException { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Username { get; set; }
    }

    [DataContract]
    public class EventView
    {
        [DataMember]
        public DateTime? DateModified { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public string SourceTable { get; set; }
    }
}