using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using DataAccess.EntityModel;

namespace BankServices
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
        IEnumerable<Gender> Genders();

        [OperationContract]
        Role GetRoleById(int id);

        [OperationContract]
        int GetRoleIdByName(string name);

        [OperationContract]
        IQueryable<Role> GetRoles(string username);

        [OperationContract]
        bool IsUserInRole(string username, int roleId);

        [OperationContract]
        IEnumerable<User> ListAll();

        [OperationContract]
        IEnumerable<Role> ListRoles();

        [OperationContract]
        User ReadByUsername(string username);

        [OperationContract]
        bool Register(User user);

        [OperationContract]
        IEnumerable<User> Search(string query);

        [OperationContract]
        IEnumerable<UserType> TypesList();

        [OperationContract]
        void Update(User user);
    }
}