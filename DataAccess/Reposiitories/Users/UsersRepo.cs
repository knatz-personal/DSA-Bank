using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using CommonUtils;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Users
{
    /// <summary>
    /// Users Repo
    /// </summary>
    public class UsersRepo : IDataRepository<User>
    {
        private readonly DsaDataContext _db = new DsaDataContext();


        /// <summary>
        /// List All
        /// </summary>
        /// <returns></returns>
        public IQueryable<User> ListAll()
        {
            return _db.Users.AsQueryable();
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="newItem">new Item</param>
        /// <returns></returns>
        public void Create(User newItem)
        {
            using (var ts = new TransactionScope())
            {
                using (var context = new DsaDataContext())
                {
                    context.Database.Connection.Open();
                    try
                    {
                        context.Users.Add(newItem);
                        context.SaveChanges();
                        ts.Complete();
                    }
                    catch
                    {
                        ts.Dispose();
                    }
                    finally
                    {
                        if (context.Database.Connection.State == ConnectionState.Open)
                        {
                            context.Database.Connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="itemToRead">item To Read</param>
        /// <returns></returns>
        public User Read(User itemToRead)
        {
            User result = _db.Users.Find(itemToRead.Username);
            return result;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="updatedItem">updated Item</param>
        /// <returns></returns>
        public void Update(User updatedItem)
        {
            User o = _db.Users.Find(updatedItem.Username);

            if (o != null)
            {
                o.FirstName = updatedItem.FirstName;
                o.MiddleInitial = updatedItem.MiddleInitial;
                o.LastName = updatedItem.LastName;
                o.Email = updatedItem.Email;
                o.Mobile = updatedItem.Mobile;
                o.DateOfBirth = updatedItem.DateOfBirth;
                o.Address = updatedItem.Address;
                o.GenderID = updatedItem.GenderID;
                o.TownID = updatedItem.TownID;
                o.Blocked = updatedItem.Blocked;
                o.NoOfAttempts = updatedItem.NoOfAttempts;
                _db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="itemToDelete">item To Delete</param>
        /// <returns></returns>
        public void Delete(User itemToDelete)
        {
            try
            {
                User o = _db.Users.Find(itemToDelete.Username);
                if (o != null)
                {
                    o.Blocked = true;
                    _db.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Unable to disable record (Users cannot be deleted)");
            }
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="query">query</param>
        /// <returns></returns>
        public IEnumerable<User> Search(string query)
        {
            IQueryable<User> result = _db.Users.Where(u => u.Username.Contains(query));
            return result;
        }

        /// <summary>
        ///     Gets a list of user-names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetUsernames()
        {
            return _db.Users.Select(u => u.Username).ToList();
        }

        /// <summary>
        ///     Authenticates the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        /// <param name="password">The string password.</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
            bool isGenuine = false;
            User u = _db.Users.Find(username);
            string hpass = HashingUtil.GenerateSaltedHash(password, u.Salt);
            isGenuine = hpass == u.Password;
            return isGenuine;
        }


        /// <summary>
        ///     Blocks the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void Block(string username)
        {
            var u = Read(new User { Username = username });
            u.Blocked = true;
            Update(u);
        }

        /// <summary>
        /// Doe User Name Exist
        /// </summary>
        /// <param name="username">username</param>
        /// <returns></returns>
        public bool DoesUserNameExist(string username)
        {
            bool ans;
            ans = _db.Users.Count(u => u.Username == username &&
                                       username != null) > 0;
            return ans;
        }

        /// <summary>
        ///     Increments the number of failed login attempts.
        /// </summary>
        /// <param name="username">The user-name.</param>
        public void IncrementNoOfAttempts(string username)
        {
            var u = Read(new User { Username = username });
            u.NoOfAttempts++;
            Update(u);
        }

        /// <summary>
        ///     Resets the number of failed login attempts.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void ResetNoOfAttempts(string username)
        {
            var u = Read(new User { Username = username});
            u.NoOfAttempts = 0;
            Update(u);
        }

        /// <summary>
        ///     Unblock the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void UnBlockUser(string username)
        {
            var u = Read(new User { Username = username });
            u.Blocked = false;
            Update(u);
        }

        /// <summary>
        ///     A list of users and their assigned roles.
        /// </summary>
        /// <returns>IQueryable</returns>
        public IQueryable UserRoles()
        {
            return (from u in _db.Users
                    from r in u.Roles
                    group r.Name by u.Username
                        into urlist
                        select urlist);
        }
    }
}