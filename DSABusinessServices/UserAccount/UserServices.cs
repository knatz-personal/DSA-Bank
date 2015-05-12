using DataAccess.EntityModel;
using DataAccess.Reposiitories;
using DataAccess.Reposiitories.Users;
using DSABusinessServices.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSABusinessServices.UserAccount
{
    public class UserServices : IUserServices
    {
        private const string _dateFormat = "d/M/yyyy HH:mm:ss";

        public void AllocateRole(string username, int roleId)
        {
            new RolesRepo().Allocate(username, roleId);
        }

        public bool Authenticate(string username, string password)
        {
            var user = new UsersRepo();

            if (user.DoesUserNameExist(username))
            {
                User tmp = user.Read(new User { Username = username });
                if (tmp != null)
                {
                    if (tmp.NoOfAttempts <= 3)
                    {
                        if (tmp.Blocked)
                        {
                            throw new UserAccountBlockedException();
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
                User user = new UsersRepo().Read(new User { Username = username });
                new UsersRepo().Delete(user);
            }
            catch (Exception)
            {
                throw new DataInsertionException();
            }
        }

        public bool DoesUsernameExist(string username)
        {
            return new UsersRepo().DoesUserNameExist(username);
        }

        public IEnumerable<GenderView> Genders()
        {
            return new GendersRepo().ListAll().Select(g => new GenderView
            {
                ID = g.ID,
                Name = g.Name
            });
        }

        public string GenerateToken()
        {
            DateTime current = DateTime.Now.AddMinutes(10);
            string token = (current.ToFileTime() / 93939109) * 151 + "";
            return token;
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
            var list = new RolesRepo().GetRolesOfUser(username).Select(r => new RoleView()
            {
                ID = r.ID,
                Name = r.Name
            });

            return list;
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
                GenderName = u.Gender.Name,
                TownID = u.TownID,
                TownName = u.Town.Name,
                TypeID = u.TypeID,
                TypeName = u.UserType.Name,
                Blocked = u.Blocked,
                NoOfAttempts = u.NoOfAttempts
            });
            return list;
        }

        public IQueryable<string> ListUsernames()
        {
            return new UsersRepo().GetUsernames().AsQueryable();
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

            if (usersRepo.DoesUserNameExist(user.Username) == false)
            {
                try
                {
                    usersRepo.Create(new User
                    {
                        Username = user.Username,
                        Password = user.Password,
                        Salt = user.Salt,
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
                    var rore = new RolesRepo();
                    int defaultRole = rore.GetRoleByName("Customer").ID;
                    rore.Allocate(user.Username, defaultRole);
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
                throw new DataUpdateException();
            }
        }

        public bool ValidateToken(string securityToken)
        {
            bool isValidToken = false;
            try
            {
                long fileTime = (long)((Convert.ToDouble(securityToken) / 151) * 93939109);
                DateTime date = DateTime.FromFileTime(fileTime);
                //is valid date time value
                if (DateTime.Now < date)
                {
                    isValidToken = true;
                }
            }
            catch
            {
            }
            return isValidToken;
        }
    }
}