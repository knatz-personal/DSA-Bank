using System.Collections.Generic;
using System.Linq;
using BankServices.CustomExceptions;
using DataAccess;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;

namespace BankServices
{
    public class UserServices : IUserServices
    {
        public void AllocateRole(string username, int roleId)
        {
            new RolesRepo().Allocate(username, roleId);
        }

        public bool Authenticate(string username, string password)
        {
            var user = new UsersRepo();

            if (user.DoeUserNameExist(username))
            {
                User tmp = ReadByUsername(username);
                if (tmp != null)
                {
                    if (tmp.NoOfAttempts <= 3)
                    {
                        if (tmp.Blocked)
                        {
                            throw new AccountBlockedException();
                        }
                        if (user.Authenticate(username, password))
                        {
                            user.ResetNoOfAttempts(username);
                            return true;
                        }
                        user.IncrementNoOfAttempts(username);
                    }
                    else
                    {
                        user.Block(username);
                    }
                }
            }
            return false;
        }

        public void DeallocateRole(string username, int roleId)
        {
            new RolesRepo().DeAllocate(username, roleId);
        }

        public void Delete(string username)
        {
            User user = ReadByUsername(username);
            new UsersRepo().Delete(user);
        }

        public bool DoesUsernameExist(string username)
        {
            return new UsersRepo().DoeUserNameExist(username);
        }

        public IEnumerable<Gender> Genders()
        {
            return new GendersRepo().ListAll();
        }

        public Role GetRoleById(int id)
        {
            return new RolesRepo().Read(new Role {ID = id});
        }

        public int GetRoleIdByName(string name)
        {
            return new RolesRepo().GetRoleByName(name).ID;
        }

        public IQueryable<Role> GetRoles(string username)
        {
            return new RolesRepo().GetRolesOfUser(username);
        }

        public bool IsUserInRole(string username, int roleId)
        {
            return
                ((new RolesRepo().GetRolesOfUser(username)).SingleOrDefault(
                    t => t.ID == roleId) != null);
        }

        public IQueryable<User> ListUsers()
        {
            var list = new UsersRepo().ListAll();
            return list;
        }

        public IEnumerable<Role> ListRoles()
        {
            return new RolesRepo().ListAll();
        }

        public User ReadByUsername(string username)
        {
            return new UsersRepo().Read(new User {Username = username});
        }

        public bool Register(User user)
        {
            var usersRepo = new UsersRepo();

            if (usersRepo.DoeUserNameExist(user.Username) == false)
            {
                using (var context = new DsaDataContext())
                {
                    //using (var transaction = context.BeginTransaction(IsolationLevel.RepeatableRead))
                    //{

                    //    context.SaveChanges();
                    //    transaction.Commit();
                    //}
                }
            }
            else
            {
                throw new UserAlreadyExistsException();
            }
            return false;
        }

        public IEnumerable<User> Search(string query)
        {
            return new UsersRepo().Search(query);
        }

        public IEnumerable<UserType> TypesList()
        {
            return new UserTypesRepo().ListAll();
        }

        public void Update(User user)
        {
            new UsersRepo().Update(user);
        }
    }
}