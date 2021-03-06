﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManager.UserServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServices.IUserServices")]
    public interface IUserServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/AllocateRole", ReplyAction="http://tempuri.org/IUserServices/AllocateRoleResponse")]
        void AllocateRole(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/AllocateRole", ReplyAction="http://tempuri.org/IUserServices/AllocateRoleResponse")]
        System.Threading.Tasks.Task AllocateRoleAsync(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Authenticate", ReplyAction="http://tempuri.org/IUserServices/AuthenticateResponse")]
        bool Authenticate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Authenticate", ReplyAction="http://tempuri.org/IUserServices/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DeallocateRole", ReplyAction="http://tempuri.org/IUserServices/DeallocateRoleResponse")]
        void DeallocateRole(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DeallocateRole", ReplyAction="http://tempuri.org/IUserServices/DeallocateRoleResponse")]
        System.Threading.Tasks.Task DeallocateRoleAsync(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Delete", ReplyAction="http://tempuri.org/IUserServices/DeleteResponse")]
        void Delete(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Delete", ReplyAction="http://tempuri.org/IUserServices/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DoesUsernameExist", ReplyAction="http://tempuri.org/IUserServices/DoesUsernameExistResponse")]
        bool DoesUsernameExist(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DoesUsernameExist", ReplyAction="http://tempuri.org/IUserServices/DoesUsernameExistResponse")]
        System.Threading.Tasks.Task<bool> DoesUsernameExistAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/IsUserInRole", ReplyAction="http://tempuri.org/IUserServices/IsUserInRoleResponse")]
        bool IsUserInRole(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/IsUserInRole", ReplyAction="http://tempuri.org/IUserServices/IsUserInRoleResponse")]
        System.Threading.Tasks.Task<bool> IsUserInRoleAsync(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Genders", ReplyAction="http://tempuri.org/IUserServices/GendersResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.GenderView> Genders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Genders", ReplyAction="http://tempuri.org/IUserServices/GendersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.GenderView>> GendersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GenerateToken", ReplyAction="http://tempuri.org/IUserServices/GenerateTokenResponse")]
        string GenerateToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GenerateToken", ReplyAction="http://tempuri.org/IUserServices/GenerateTokenResponse")]
        System.Threading.Tasks.Task<string> GenerateTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleById", ReplyAction="http://tempuri.org/IUserServices/GetRoleByIdResponse")]
        WcfServiceDSABank.RoleView GetRoleById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleById", ReplyAction="http://tempuri.org/IUserServices/GetRoleByIdResponse")]
        System.Threading.Tasks.Task<WcfServiceDSABank.RoleView> GetRoleByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleIdByName", ReplyAction="http://tempuri.org/IUserServices/GetRoleIdByNameResponse")]
        int GetRoleIdByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleIdByName", ReplyAction="http://tempuri.org/IUserServices/GetRoleIdByNameResponse")]
        System.Threading.Tasks.Task<int> GetRoleIdByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoles", ReplyAction="http://tempuri.org/IUserServices/GetRolesResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.RoleView> GetRoles(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoles", ReplyAction="http://tempuri.org/IUserServices/GetRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.RoleView>> GetRolesAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListRoles", ReplyAction="http://tempuri.org/IUserServices/ListRolesResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.RoleView> ListRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListRoles", ReplyAction="http://tempuri.org/IUserServices/ListRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.RoleView>> ListRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsers", ReplyAction="http://tempuri.org/IUserServices/ListUsersResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.UserView> ListUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsers", ReplyAction="http://tempuri.org/IUserServices/ListUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.UserView>> ListUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsernames", ReplyAction="http://tempuri.org/IUserServices/ListUsernamesResponse")]
        System.Collections.Generic.List<string> ListUsernames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsernames", ReplyAction="http://tempuri.org/IUserServices/ListUsernamesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListUsernamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ReadByUsername", ReplyAction="http://tempuri.org/IUserServices/ReadByUsernameResponse")]
        WcfServiceDSABank.UserView ReadByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ReadByUsername", ReplyAction="http://tempuri.org/IUserServices/ReadByUsernameResponse")]
        System.Threading.Tasks.Task<WcfServiceDSABank.UserView> ReadByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Register", ReplyAction="http://tempuri.org/IUserServices/RegisterResponse")]
        bool Register(WcfServiceDSABank.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Register", ReplyAction="http://tempuri.org/IUserServices/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(WcfServiceDSABank.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Search", ReplyAction="http://tempuri.org/IUserServices/SearchResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.UserView> Search(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Search", ReplyAction="http://tempuri.org/IUserServices/SearchResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.UserView>> SearchAsync(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Towns", ReplyAction="http://tempuri.org/IUserServices/TownsResponse")]
        System.Collections.Generic.List<WcfServiceDSABank.TownView> Towns();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Towns", ReplyAction="http://tempuri.org/IUserServices/TownsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TownView>> TownsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Update", ReplyAction="http://tempuri.org/IUserServices/UpdateResponse")]
        void Update(WcfServiceDSABank.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Update", ReplyAction="http://tempuri.org/IUserServices/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(WcfServiceDSABank.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ValidateToken", ReplyAction="http://tempuri.org/IUserServices/ValidateTokenResponse")]
        bool ValidateToken(string securityToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ValidateToken", ReplyAction="http://tempuri.org/IUserServices/ValidateTokenResponse")]
        System.Threading.Tasks.Task<bool> ValidateTokenAsync(string securityToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServicesChannel : BankManager.UserServices.IUserServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServicesClient : System.ServiceModel.ClientBase<BankManager.UserServices.IUserServices>, BankManager.UserServices.IUserServices {
        
        public UserServicesClient() {
        }
        
        public UserServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AllocateRole(string username, int roleId) {
            base.Channel.AllocateRole(username, roleId);
        }
        
        public System.Threading.Tasks.Task AllocateRoleAsync(string username, int roleId) {
            return base.Channel.AllocateRoleAsync(username, roleId);
        }
        
        public bool Authenticate(string username, string password) {
            return base.Channel.Authenticate(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(string username, string password) {
            return base.Channel.AuthenticateAsync(username, password);
        }
        
        public void DeallocateRole(string username, int roleId) {
            base.Channel.DeallocateRole(username, roleId);
        }
        
        public System.Threading.Tasks.Task DeallocateRoleAsync(string username, int roleId) {
            return base.Channel.DeallocateRoleAsync(username, roleId);
        }
        
        public void Delete(string username) {
            base.Channel.Delete(username);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(string username) {
            return base.Channel.DeleteAsync(username);
        }
        
        public bool DoesUsernameExist(string username) {
            return base.Channel.DoesUsernameExist(username);
        }
        
        public System.Threading.Tasks.Task<bool> DoesUsernameExistAsync(string username) {
            return base.Channel.DoesUsernameExistAsync(username);
        }
        
        public bool IsUserInRole(string username, int roleId) {
            return base.Channel.IsUserInRole(username, roleId);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserInRoleAsync(string username, int roleId) {
            return base.Channel.IsUserInRoleAsync(username, roleId);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.GenderView> Genders() {
            return base.Channel.Genders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.GenderView>> GendersAsync() {
            return base.Channel.GendersAsync();
        }
        
        public string GenerateToken() {
            return base.Channel.GenerateToken();
        }
        
        public System.Threading.Tasks.Task<string> GenerateTokenAsync() {
            return base.Channel.GenerateTokenAsync();
        }
        
        public WcfServiceDSABank.RoleView GetRoleById(int id) {
            return base.Channel.GetRoleById(id);
        }
        
        public System.Threading.Tasks.Task<WcfServiceDSABank.RoleView> GetRoleByIdAsync(int id) {
            return base.Channel.GetRoleByIdAsync(id);
        }
        
        public int GetRoleIdByName(string name) {
            return base.Channel.GetRoleIdByName(name);
        }
        
        public System.Threading.Tasks.Task<int> GetRoleIdByNameAsync(string name) {
            return base.Channel.GetRoleIdByNameAsync(name);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.RoleView> GetRoles(string username) {
            return base.Channel.GetRoles(username);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.RoleView>> GetRolesAsync(string username) {
            return base.Channel.GetRolesAsync(username);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.RoleView> ListRoles() {
            return base.Channel.ListRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.RoleView>> ListRolesAsync() {
            return base.Channel.ListRolesAsync();
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.UserView> ListUsers() {
            return base.Channel.ListUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.UserView>> ListUsersAsync() {
            return base.Channel.ListUsersAsync();
        }
        
        public System.Collections.Generic.List<string> ListUsernames() {
            return base.Channel.ListUsernames();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListUsernamesAsync() {
            return base.Channel.ListUsernamesAsync();
        }
        
        public WcfServiceDSABank.UserView ReadByUsername(string username) {
            return base.Channel.ReadByUsername(username);
        }
        
        public System.Threading.Tasks.Task<WcfServiceDSABank.UserView> ReadByUsernameAsync(string username) {
            return base.Channel.ReadByUsernameAsync(username);
        }
        
        public bool Register(WcfServiceDSABank.UserView user) {
            return base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(WcfServiceDSABank.UserView user) {
            return base.Channel.RegisterAsync(user);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.UserView> Search(string query) {
            return base.Channel.Search(query);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.UserView>> SearchAsync(string query) {
            return base.Channel.SearchAsync(query);
        }
        
        public System.Collections.Generic.List<WcfServiceDSABank.TownView> Towns() {
            return base.Channel.Towns();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfServiceDSABank.TownView>> TownsAsync() {
            return base.Channel.TownsAsync();
        }
        
        public void Update(WcfServiceDSABank.UserView user) {
            base.Channel.Update(user);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(WcfServiceDSABank.UserView user) {
            return base.Channel.UpdateAsync(user);
        }
        
        public bool ValidateToken(string securityToken) {
            return base.Channel.ValidateToken(securityToken);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateTokenAsync(string securityToken) {
            return base.Channel.ValidateTokenAsync(securityToken);
        }
    }
}
