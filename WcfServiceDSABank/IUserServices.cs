using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceDSABank
{
    [ServiceContract]
    public interface IUserServices
    {
        [OperationContract]
        void AllocateRole(string username, int roleId);

        [OperationContract]
        bool Authenticate(string username, string password);

        [OperationContract]
        void DeallocateRole(string username, int roleId);

        [OperationContract]
        void Delete(string username);

        [OperationContract]
        bool DoesUsernameExist(string username);

        [OperationContract]
        bool IsUserInRole(string username, int roleId);

        [OperationContract]
        IEnumerable<GenderView> Genders();

        [OperationContract]
        string GenerateToken();

        [OperationContract]
        RoleView GetRoleById(int id);

        [OperationContract]
        int GetRoleIdByName(string name);

        [OperationContract]
        IQueryable<RoleView> GetRoles(string username);

        [OperationContract]
        IEnumerable<RoleView> ListRoles();

        [OperationContract]
        IQueryable<UserView> ListUsers();

        [OperationContract]
        IQueryable<string> ListUsernames();

        [OperationContract]
        UserView ReadByUsername(string username);

        [OperationContract]
        bool Register(UserView user);

        [OperationContract]
        IEnumerable<UserView> Search(string query);

        [OperationContract]
        IEnumerable<TownView> Towns();

        [OperationContract]
        void Update(UserView user);

        [OperationContract]
        bool ValidateToken(string securityToken);
    }

    [DataContract]
    public class GenderView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class RoleView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class TownView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class UserView
    {
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public bool Blocked { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public int? GenderID { get; set; }

        [DataMember]
        public string GenderName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string MiddleInitial { get; set; }

        [DataMember]
        public int Mobile { get; set; }

        [DataMember]
        public int NoOfAttempts { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Salt { get; set; }

        [DataMember]
        public int? TownID { get; set; }

        [DataMember]
        public string TownName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public IEnumerable<RoleView> Roles { get; set; }
    }
}