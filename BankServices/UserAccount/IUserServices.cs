using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BankServices.UserAccount
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
        IEnumerable<GenderView> Genders();

        [OperationContract]
        RoleView GetRoleById(int id);

        [OperationContract]
        int GetRoleIdByName(string name);

        [OperationContract]
        IQueryable<RoleView> GetRoles(string username);

        [OperationContract]
        bool IsUserInRole(string username, int roleId);

        [OperationContract]
        IQueryable<UserView> ListUsers();

        [OperationContract]
        IEnumerable<RoleView> ListRoles();

        [OperationContract]
        UserView ReadByUsername(string username);

        [OperationContract]
        bool Register(UserView user);

        [OperationContract]
        IEnumerable<UserView> Search(string query);

        [OperationContract]
        IEnumerable<UserTypeView> TypesList();

        [OperationContract]
        void Update(UserView user);
    }

    [DataContract]
    public class UserView
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleInitial { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public int? GenderID { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Mobile { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int? TownID { get; set; }

        [DataMember]
        public int? TypeID { get; set; }

        [DataMember]
        public bool Blocked { get; set; }

        [DataMember]
        public int NoOfAttempts { get; set; }
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
    public class GenderView
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
    public class UserTypeView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}