using System;
using System.Collections.Generic;
using System.Linq;
using BankServices.CustomExceptions;
using DataAccess;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;

namespace BankServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserServices" in both code and config file together.
    public class UserServices : IUserServices
    {
        public void AllocateRole(string username, int roleId)
        {
            throw new NotImplementedException();
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

        //TODO: Roles Allocation
        public void DeallocateRole(string username, int roleId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int GetRoleIdByName(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Role> GetRoles(string username)
        {
            return new RolesRepo().GetRolesOfUser(username);
        }
        public bool IsUserInRole(string username, int roleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ListAll()
        {
            return new UsersRepo().ListAll();
        }

        public IEnumerable<Role> ListRoles()
        {
            throw new NotImplementedException();
        }

        public User ReadByUsername(string username)
        {
            return new UsersRepo().Read(new User { Username = username });
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
