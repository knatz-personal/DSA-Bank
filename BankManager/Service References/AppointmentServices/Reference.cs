﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManager.AppointmentServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentView", Namespace="http://schemas.datacontract.org/2004/07/BankServices.Appointment")]
    [System.SerializableAttribute()]
    public partial class AppointmentView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsAcceptedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SuggestedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan SuggestedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((object.ReferenceEquals(this.DurationField, value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsAccepted {
            get {
                return this.IsAcceptedField;
            }
            set {
                if ((this.IsAcceptedField.Equals(value) != true)) {
                    this.IsAcceptedField = value;
                    this.RaisePropertyChanged("IsAccepted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SuggestedDate {
            get {
                return this.SuggestedDateField;
            }
            set {
                if ((this.SuggestedDateField.Equals(value) != true)) {
                    this.SuggestedDateField = value;
                    this.RaisePropertyChanged("SuggestedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan SuggestedTime {
            get {
                return this.SuggestedTimeField;
            }
            set {
                if ((this.SuggestedTimeField.Equals(value) != true)) {
                    this.SuggestedTimeField = value;
                    this.RaisePropertyChanged("SuggestedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AppointmentServices.IAppointmentServices")]
    public interface IAppointmentServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/ListAppointments", ReplyAction="http://tempuri.org/IAppointmentServices/ListAppointmentsResponse")]
        System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView> ListAppointments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/ListAppointments", ReplyAction="http://tempuri.org/IAppointmentServices/ListAppointmentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView>> ListAppointmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/FilterAppointmentList", ReplyAction="http://tempuri.org/IAppointmentServices/FilterAppointmentListResponse")]
        System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView> FilterAppointmentList(System.Nullable<bool> isAccepted, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/FilterAppointmentList", ReplyAction="http://tempuri.org/IAppointmentServices/FilterAppointmentListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView>> FilterAppointmentListAsync(System.Nullable<bool> isAccepted, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/Schedule", ReplyAction="http://tempuri.org/IAppointmentServices/ScheduleResponse")]
        void Schedule(BankManager.AppointmentServices.AppointmentView appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/Schedule", ReplyAction="http://tempuri.org/IAppointmentServices/ScheduleResponse")]
        System.Threading.Tasks.Task ScheduleAsync(BankManager.AppointmentServices.AppointmentView appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/Response", ReplyAction="http://tempuri.org/IAppointmentServices/ResponseResponse")]
        void Response(BankManager.AppointmentServices.AppointmentView appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/Response", ReplyAction="http://tempuri.org/IAppointmentServices/ResponseResponse")]
        System.Threading.Tasks.Task ResponseAsync(BankManager.AppointmentServices.AppointmentView appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/Delete", ReplyAction="http://tempuri.org/IAppointmentServices/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentServices/Delete", ReplyAction="http://tempuri.org/IAppointmentServices/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppointmentServicesChannel : BankManager.AppointmentServices.IAppointmentServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppointmentServicesClient : System.ServiceModel.ClientBase<BankManager.AppointmentServices.IAppointmentServices>, BankManager.AppointmentServices.IAppointmentServices {
        
        public AppointmentServicesClient() {
        }
        
        public AppointmentServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppointmentServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppointmentServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppointmentServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView> ListAppointments() {
            return base.Channel.ListAppointments();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView>> ListAppointmentsAsync() {
            return base.Channel.ListAppointmentsAsync();
        }
        
        public System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView> FilterAppointmentList(System.Nullable<bool> isAccepted, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.FilterAppointmentList(isAccepted, start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.AppointmentServices.AppointmentView>> FilterAppointmentListAsync(System.Nullable<bool> isAccepted, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.FilterAppointmentListAsync(isAccepted, start, end);
        }
        
        public void Schedule(BankManager.AppointmentServices.AppointmentView appointment) {
            base.Channel.Schedule(appointment);
        }
        
        public System.Threading.Tasks.Task ScheduleAsync(BankManager.AppointmentServices.AppointmentView appointment) {
            return base.Channel.ScheduleAsync(appointment);
        }
        
        public void Response(BankManager.AppointmentServices.AppointmentView appointment) {
            base.Channel.Response(appointment);
        }
        
        public System.Threading.Tasks.Task ResponseAsync(BankManager.AppointmentServices.AppointmentView appointment) {
            return base.Channel.ResponseAsync(appointment);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}