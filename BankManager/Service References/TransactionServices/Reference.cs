﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManager.TransactionServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TransactionServices.ITransactionServices")]
    public interface ITransactionServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListAccountNumbers", ReplyAction="http://tempuri.org/ITransactionServices/ListAccountNumbersResponse")]
        System.Collections.Generic.List<string> ListAccountNumbers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListAccountNumbers", ReplyAction="http://tempuri.org/ITransactionServices/ListAccountNumbersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListAccountNumbersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListUserTransactions", ReplyAction="http://tempuri.org/ITransactionServices/ListUserTransactionsResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.TransactionView> ListUserTransactions(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/ListUserTransactions", ReplyAction="http://tempuri.org/ITransactionServices/ListUserTransactionsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TransactionView>> ListUserTransactionsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/FilterTransactions", ReplyAction="http://tempuri.org/ITransactionServices/FilterTransactionsResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.TransactionView> FilterTransactions(string username, int accountNo, System.Windows.Forms.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/FilterTransactions", ReplyAction="http://tempuri.org/ITransactionServices/FilterTransactionsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TransactionView>> FilterTransactionsAsync(string username, int accountNo, System.Windows.Forms.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionDetails", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionDetailsResponse")]
        WcfServiceDSABank.TransactionView GetTransactionDetails(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionDetails", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionDetailsResponse")]
        System.Threading.Tasks.Task<WcfServiceDSABank.TransactionView> GetTransactionDetailsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionTypes", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionTypesResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.TransactionTypeView> GetTransactionTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/GetTransactionTypes", ReplyAction="http://tempuri.org/ITransactionServices/GetTransactionTypesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TransactionTypeView>> GetTransactionTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/TermDeposit", ReplyAction="http://tempuri.org/ITransactionServices/TermDepositResponse")]
        void TermDeposit(WcfServiceDSABank.FixedAccountView accountInfo, WcfServiceDSABank.TransactionView transactionInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/TermDeposit", ReplyAction="http://tempuri.org/ITransactionServices/TermDepositResponse")]
        System.Threading.Tasks.Task TermDepositAsync(WcfServiceDSABank.FixedAccountView accountInfo, WcfServiceDSABank.TransactionView transactionInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/PersonalTransfer", ReplyAction="http://tempuri.org/ITransactionServices/PersonalTransferResponse")]
        void PersonalTransfer(WcfServiceDSABank.TransactionView item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/PersonalTransfer", ReplyAction="http://tempuri.org/ITransactionServices/PersonalTransferResponse")]
        System.Threading.Tasks.Task PersonalTransferAsync(WcfServiceDSABank.TransactionView item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/LocalTransfer", ReplyAction="http://tempuri.org/ITransactionServices/LocalTransferResponse")]
        void LocalTransfer(WcfServiceDSABank.TransactionView item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/LocalTransfer", ReplyAction="http://tempuri.org/ITransactionServices/LocalTransferResponse")]
        System.Threading.Tasks.Task LocalTransferAsync(WcfServiceDSABank.TransactionView item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/Delete", ReplyAction="http://tempuri.org/ITransactionServices/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionServices/Delete", ReplyAction="http://tempuri.org/ITransactionServices/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransactionServicesChannel : BankManager.TransactionServices.ITransactionServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransactionServicesClient : System.ServiceModel.ClientBase<BankManager.TransactionServices.ITransactionServices>, BankManager.TransactionServices.ITransactionServices {
        
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
        
        public System.Collections.Generic.List<WcfServiceDSABank.TransactionView> ListUserTransactions(string username) {
            return base.Channel.ListUserTransactions(username);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TransactionView>> ListUserTransactionsAsync(string username) {
            return base.Channel.ListUserTransactionsAsync(username);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.TransactionView> FilterTransactions(string username, int accountNo, System.Windows.Forms.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.FilterTransactions(username, accountNo, order, start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TransactionView>> FilterTransactionsAsync(string username, int accountNo, System.Windows.Forms.SortOrder order, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.FilterTransactionsAsync(username, accountNo, order, start, end);
        }
        
        public WcfServiceDSABank.TransactionView GetTransactionDetails(int id) {
            return base.Channel.GetTransactionDetails(id);
        }
        
        public System.Threading.Tasks.Task<WcfServiceDSABank.TransactionView> GetTransactionDetailsAsync(int id) {
            return base.Channel.GetTransactionDetailsAsync(id);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.TransactionTypeView> GetTransactionTypes() {
            return base.Channel.GetTransactionTypes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TransactionTypeView>> GetTransactionTypesAsync() {
            return base.Channel.GetTransactionTypesAsync();
        }
        
        public void TermDeposit(WcfServiceDSABank.FixedAccountView accountInfo, WcfServiceDSABank.TransactionView transactionInfo) {
            base.Channel.TermDeposit(accountInfo, transactionInfo);
        }
        
        public System.Threading.Tasks.Task TermDepositAsync(WcfServiceDSABank.FixedAccountView accountInfo, WcfServiceDSABank.TransactionView transactionInfo) {
            return base.Channel.TermDepositAsync(accountInfo, transactionInfo);
        }
        
        public void PersonalTransfer(WcfServiceDSABank.TransactionView item) {
            base.Channel.PersonalTransfer(item);
        }
        
        public System.Threading.Tasks.Task PersonalTransferAsync(WcfServiceDSABank.TransactionView item) {
            return base.Channel.PersonalTransferAsync(item);
        }
        
        public void LocalTransfer(WcfServiceDSABank.TransactionView item) {
            base.Channel.LocalTransfer(item);
        }
        
        public System.Threading.Tasks.Task LocalTransferAsync(WcfServiceDSABank.TransactionView item) {
            return base.Channel.LocalTransferAsync(item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
