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



        public IEnumerable<Role> ListRoles()
        {
            return new RolesRepo().ListAll();
        }

        public IQueryable<UserView> ListUsers()
        {
            var list = new UsersRepo().ListAll().Select(u => new UserView()
            {
                Username = u.Username,
                Password = u.Password,
                FirstName = u.FirstName,
                MiddleInitial = u.MiddleInitial,
                LastName = u.LastName,
                Email = u.Email,
                Mobile = u.Mobile,
                DateOfBirth = u.DateOfBirth,
                Address = u.Address,
                GenderID = u.GenderID,
                TownID = u.TownID,
                TypeID = u.TypeID,
                Blocked = u.Blocked,
                NoOfAttempts = u.NoOfAttempts
            });
            return list;
        }

        public User ReadByUsername(string username)
        {
            return new UsersRepo().Read(new User {Username = username});
        }

        public bool Register(UserView user)
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

        public IEnumerable<UserView> Search(string query)
        {
            //return new UsersRepo().Search(query);
            return null;
        }

        public IEnumerable<UserType> TypesList()
        {
            return new UserTypesRepo().ListAll();
        }

        public void Update(UserView user)
        {
            //new UsersRepo().Update(user);
        }
    }
}