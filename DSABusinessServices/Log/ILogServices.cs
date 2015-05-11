using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DSABusinessServices.Log
{
    [ServiceContract]
    public interface ILogServices
    {
        [OperationContract]
        void LogError(string username, string message, string innerException);

        [OperationContract]
        IQueryable<ErrorView> ListErrors();

        [OperationContract]
        void DeleteError(int id);

        [OperationContract]
        void LogEvent(string username, string message, string source);

        [OperationContract]
        IQueryable<EventView> ListEvents();

        [OperationContract]
        void DeleteEvent(int id);
    }

    [DataContract]
    public class EventView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string SourceTable { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public DateTime? DateModified { get; set; }
    }

    [DataContract]
    public class ErrorView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string InnerException { get; set; }

        [DataMember]
        public DateTime? DateTriggered { get; set; }
    }
}