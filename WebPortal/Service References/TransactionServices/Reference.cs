﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPortal.TransactionServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionView", Namespace="http://schemas.datacontract.org/2004/07/DSABusinessServices.BankTransaction")]
    [System.SerializableAttribute()]
    public partial class TransactionView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AccountFromIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AccountToIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateIssuedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeNameField;
        
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
        public System.Nullable<int> AccountFromID {
            get {
                return this.AccountFromIDField;
            }
            set {
                if ((this.AccountFromIDField.Equals(value) != true)) {
                    this.AccountFromIDField = value;
                    this.RaisePropertyChanged("AccountFromID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> AccountToID {
            get {
                return this.AccountToIDField;
            }
            set {
                if ((this.AccountToIDField.Equals(value) != true)) {
                    this.AccountToIDField = value;
                    this.RaisePropertyChanged("AccountToID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Currency {
            get {
                return this.CurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrencyField, value) != true)) {
                    this.CurrencyField = value;
                    this.RaisePropertyChanged("Currency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateIssued {
            get {
                return this.DateIssuedField;
            }
            set {
                if ((this.DateIssuedField.Equals(value) != true)) {
                    this.DateIssuedField = value;
                    this.RaisePropertyChanged("DateIssued");
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
        public string Remarks {
            get {
                return this.RemarksField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarksField, value) != true)) {
                    this.RemarksField = value;
                    this.RaisePropertyChanged("Remarks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TypeID {
            get {
                return this.TypeIDField;
            }
            set {
                if ((this.TypeIDField.Equals(value) != true)) {
                    this.TypeIDField = value;
                    this.RaisePropertyChanged("TypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SortOrder", Namespace="http://schemas.datacontract.org/2004/07/DSABusinessServices.BankTransaction")]
    public enum SortOrder : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ascending = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Descending = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionTypeView", Namespace="http://schemas.datacontract.org/2004/07/DSABusinessServices.BankTransaction")]
    [System.SerializableAttribute()]
    public partial class TransactionTypeView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TransactionServices.ITransactionServices")]
    public interface ITransactionServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListAccountNumbers", ReplyAction="http://tempuri.org/ITransactionServices/ListAccountNumbersResponse")]
        System.Collections.Generic.List<string> ListAccountNumbers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListAccountNumbers", ReplyAction="http://tempuri.org/ITransactionServices/ListAccountNumbersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListAccountNumbersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListUserTransactions", ReplyAction="http://tempuri.org/ITransactionServices/ListUserTransactionsResponse")]
        System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView> ListUserTransactions(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListUserTransactions", ReplyAction="http://tempuri.org/ITransactionServices/ListUserTransactionsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView>> ListUserTransactionsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/FilterTransactions", ReplyAction="http://tempuri.org/ITransactionServices/FilterTransactionsResponse")]
        System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView> FilterTransactions(string username, int accountNo, WebPortal.TransactionServices.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/FilterTransactions", ReplyAction="http://tempuri.org/ITransactionServices/FilterTransactionsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView>> FilterTransactionsAsync(string username, int accountNo, WebPortal.TransactionServices.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionDetails", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionDetailsResponse")]
        WebPortal.TransactionServices.TransactionView GetTransactionDetails(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionDetails", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionDetailsResponse")]
        System.Threading.Tasks.Task<WebPortal.TransactionServices.TransactionView> GetTransactionDetailsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionTypes", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionTypesResponse")]
        System.Collections.Generic.List<WebPortal.TransactionServices.TransactionTypeView> GetTransactionTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionTypes", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionTypesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.TransactionServices.TransactionTypeView>> GetTransactionTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/Create", ReplyAction="http://tempuri.org/ITransactionServices/CreateResponse")]
        void Create(WebPortal.TransactionServices.TransactionView item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/Create", ReplyAction="http://tempuri.org/ITransactionServices/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(WebPortal.TransactionServices.TransactionView item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/Delete", ReplyAction="http://tempuri.org/ITransactionServices/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/Delete", ReplyAction="http://tempuri.org/ITransactionServices/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransactionServicesChannel : WebPortal.TransactionServices.ITransactionServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransactionServicesClient : System.ServiceModel.ClientBase<WebPortal.TransactionServices.ITransactionServices>, WebPortal.TransactionServices.ITransactionServices {
        
        public TransactionServicesClient() {
        }
        
        public TransactionServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransactionServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<string> ListAccountNumbers() {
            return base.Channel.ListAccountNumbers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListAccountNumbersAsync() {
            return base.Channel.ListAccountNumbersAsync();
        }
        
        public System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView> ListUserTransactions(string username) {
            return base.Channel.ListUserTransactions(username);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView>> ListUserTransactionsAsync(string username) {
            return base.Channel.ListUserTransactionsAsync(username);
        }
        
        public System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView> FilterTransactions(string username, int accountNo, WebPortal.TransactionServices.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.FilterTransactions(username, accountNo, order, start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.TransactionServices.TransactionView>> FilterTransactionsAsync(string username, int accountNo, WebPortal.TransactionServices.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.FilterTransactionsAsync(username, accountNo, order, start, end);
        }
        
        public WebPortal.TransactionServices.TransactionView GetTransactionDetails(int id) {
            return base.Channel.GetTransactionDetails(id);
        }
        
        public System.Threading.Tasks.Task<WebPortal.TransactionServices.TransactionView> GetTransactionDetailsAsync(int id) {
            return base.Channel.GetTransactionDetailsAsync(id);
        }
        
        public System.Collections.Generic.List<WebPortal.TransactionServices.TransactionTypeView> GetTransactionTypes() {
            return base.Channel.GetTransactionTypes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.TransactionServices.TransactionTypeView>> GetTransactionTypesAsync() {
            return base.Channel.GetTransactionTypesAsync();
        }
        
        public void Create(WebPortal.TransactionServices.TransactionView item) {
            base.Channel.Create(item);
        }
        
        public System.Threading.Tasks.Task CreateAsync(WebPortal.TransactionServices.TransactionView item) {
            return base.Channel.CreateAsync(item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
