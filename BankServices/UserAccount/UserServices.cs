using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using BankServices.CustomExceptions;
using CommonUtils;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;
using DataAccess.Reposiitories.Users;

namespace BankServices.UserAccount
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

            if (user.DoeUserNameExist(username))
            {
                User tmp = user.Read(new User {Username = username});
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

        public KeyValuePair<string, string> GenerateToken()
        {
            DateTime current = DateTime.Now.AddMinutes(6);
            string temp = Guid.NewGuid().ToString("N") + HashingUtil.GenerateSaltValue();
            string token = EncryptionUtil.EncryptTripleDES(temp);
            string dateTime =
                EncryptionUtil.EncryptTripleDES(current.ToString(_dateFormat,
                CultureInfo.InvariantCulture));
            return new KeyValuePair<string, string>(token, dateTime);
        }

        public RoleView GetRoleById(int id)
        {
            Role r = new RolesRepo().Read(new Role {ID = id});
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

        public UserView ReadByUsername(string username)
        {
            User u = new UsersRepo().Read(new User {Username = username});
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
                throw new UpdateException();
            }
        }

        public bool ValidateToken(KeyValuePair<string, string> securityToken)
        {
            //Check token expiry
            bool isValidToken = false;
            int guidLength = 32;
            string token = EncryptionUtil.DecryptTripleDES(securityToken.Key);
            string dateTime = EncryptionUtil.DecryptTripleDES(securityToken.Value);
            var temp = new Guid();
            if (Guid.TryParse(token.Substring(0, guidLength), out temp))
            {
                //is a valid GUID
                DateTime date;
                bool isValidTime = DateTime.TryParseExact(dateTime, _dateFormat, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out date);
                if (isValidTime)
                {
                    //is valid date time value 
                    if (DateTime.Now < date)
                    {
                        isValidToken = true;
                    }
                }
            }
            return isValidToken;
        }
    }
}