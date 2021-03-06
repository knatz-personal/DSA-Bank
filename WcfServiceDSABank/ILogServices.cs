﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDSABank
{
    [ServiceContract]
    public interface ILogServices
    {
        [OperationContract]
        void DeleteError(int id);

        [OperationContract]
        void DeleteEvent(int id);

        [OperationContract]
        IQueryable<ErrorView> FilterErrorsList(string query, DateTime? start, DateTime? end);

        [OperationContract]
        IQueryable<EventView> FilterEventsList(string source, DateTime? start, DateTime? end);

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
