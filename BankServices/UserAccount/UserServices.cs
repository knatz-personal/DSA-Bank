using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BankServices.CustomExceptions;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;
using DataAccess.Reposiitories.Users;

namespace BankServices.UserAccount
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
                User tmp = user.Read(new User {Username = username});
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
                throw new Exception("An account with the given credentials was not found.");
            }
            return false;
        }

        public void DeallocateRole(string username, int roleId)
        {
            new RolesRepo().DeAllocate(username, roleId);
        }

        public void Delete(string username)
        {
            try
            {
                User user = new UsersRepo().Read(new User {Username = username});
                new UsersRepo().Delete(user);
            }
            catch (Exception)
            {
                throw new DataInsertionException();
            }
        }

        public bool DoesUsernameExist(string username)
        {
            return new UsersRepo().DoeUserNameExist(username);
        }

        public IEnumerable<GenderView> Genders()
        {
            return new GendersRepo().ListAll().Select(g => new GenderView
            {
                ID = g.ID,
                Name = g.Name
            });
        }

        public string GetGenderNameById(int id)
        {
            return new GendersRepo().Read(new Gender(){ID = id}).Name;
        }

        public RoleView GetRoleById(int id)
        {
            Role r = new RolesRepo().Read(new Role { ID = id });
            return new RoleView
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
            return new RolesRepo().GetRolesOfUser(username).Select(r => new RoleView
            {
                ID = r.ID,
                Name = r.Name
            });
        }

        public string GetTownNameById(int id)
        {
            return new TownsRepo().Read(new Town() { ID = id }).Name;
        }

        public string GetTypeNameById(int id)
        {
            return new UserTypesRepo().Read(new UserType() { ID = id }).Name;
        }

        public bool IsUserInRole(string username, int roleId)
        {
            return
                ((new RolesRepo().GetRolesOfUser(username)).SingleOrDefault(
                    t => t.ID == roleId) != null);
        }

        public IEnumerable<RoleView> ListRoles()
        {
            return new RolesRepo().ListAll().Select(r => new RoleView
            {
                ID = r.ID,
                Name = r.Name
            });
        }

        public IQueryable<UserView> ListUsers()
        {
            IQueryable<UserView> list = new UsersRepo().ListAll().Select(u => new UserView
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
            User u = new UsersRepo().Read(new User { Username = username });
            return new UserView
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
                try
                {
                    usersRepo.Create(new User
                    {
                        Username = user.Username,
                        Password = user.Password,
                        FirstName = user.FirstName,
                        MiddleInitial = user.MiddleInitial,
                        LastName = user.LastName,
                        Email = user.Email,
                        Mobile = user.Mobile,
                        DateOfBirth = user.DateOfBirth,
                        Address = user.Address,
                        GenderID = user.GenderID,
                        TownID = user.TownID,
                        TypeID = user.TypeID,
                        Blocked = user.Blocked,
                        NoOfAttempts = user.NoOfAttempts
                    });
                }
                catch (Exception)
                {
                    throw new DataInsertionException();
                }
            }
            else
            {
                throw new UserAlreadyExistsException();
            }
            return true;
        }

        public IEnumerable<UserView> Search(string query)
        {
            return new UsersRepo().Search(query).Select(u => new UserView
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

        public IEnumerable<TownView> Towns()
        {
            return new TownsRepo().ListAll().Select(g => new TownView
            {
                ID = g.ID,
                Name = g.Name
            });
        }
        public IEnumerable<UserTypeView> Types()
        {
            try
            {
                return new UserTypesRepo().ListAll().Select(u => new UserTypeView
                {
                    ID = u.ID,
                    Name = u.Name
                });
            }
            catch (Exception)
            {
                throw new DataListException();
            }
        }

        public void Update(UserView u)
        {
            try
            {
                new UsersRepo().Update(new User
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
            catch (Exception)
            {
                throw new UpdateException();
            }
        }
    }
}