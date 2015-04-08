using System;
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
                User tmp = user.Read(new User { Username = username });
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
            else
            {
                throw new Exception("An account with the given username was not found.");
            }
            return false;
        }

        public void DeallocateRole(string username, int roleId)
        {
            new RolesRepo().DeAllocate(username, roleId);
        }

        public void Delete(string username)
        {
            User user = new UsersRepo().Read(new User(){Username = username});
            new UsersRepo().Delete(user);
        }

        public bool DoesUsernameExist(string username)
        {
            return new UsersRepo().DoeUserNameExist(username);
        }

        public IEnumerable<GenderView> Genders()
        {
            return new GendersRepo().ListAll().Select(g=>new GenderView()
            {
                ID = g.ID,
                Name = g.Name
            });
        }

        public RoleView GetRoleById(int id)
        {
            var r = new RolesRepo().Read(new Role { ID = id });
            return new RoleView()
            {
                ID = r.ID,
                Name = r.Name
            };
        }

        public int GetRoleIdByName(string name)
        {
            return new RolesRepo().GetRoleByName(name).ID;
        }

        public IQueryable<RoleView> GetRoles(string username)
        {
            return new RolesRepo().GetRolesOfUser(username).Select(r => new RoleView()
            {
                ID = r.ID,
                Name = r.Name
            });
        }

        public bool IsUserInRole(string username, int roleId)
        {
            return
                ((new RolesRepo().GetRolesOfUser(username)).SingleOrDefault(
                    t => t.ID == roleId) != null);
        }
        
        public IEnumerable<RoleView> ListRoles()
        {
            return new RolesRepo().ListAll().Select(r => new RoleView()
            {
                ID = r.ID,
                Name = r.Name
            });
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

        public UserView ReadByUsername(string username)
        {
            var u = new UsersRepo().Read(new User {Username = username});
            return new UserView()
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
            };
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
            return new UsersRepo().Search(query).Select(u => new UserView()
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
        }

        public IEnumerable<UserTypeView> TypesList()
        {
            return new UserTypesRepo().ListAll().Select(u => new UserTypeView()
            {
                ID = u.ID,
                Name = u.Name
            });
        }

        public void Update(UserView u)
        {
            new UsersRepo().Update(new User()
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
        }
    }
}