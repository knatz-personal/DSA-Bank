using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories
{
    public class UsersRepo : IDataRepository<User>
    {
        private DsaDataContext _db = new DsaDataContext();

        public DsaDataContext Entity
        {
            get { return _db; }
            set { _db = value; }
        }
        

        public IQueryable<User> ListAll()
        {
            return _db.Users.AsQueryable();
        }

        public void Create(User newItem)
        {
            _db.Users.Add(newItem);
            _db.SaveChanges();
        }

        public User Read(User itemToRead)
        {
            User result = _db.Users.SingleOrDefault(u => u.Username == itemToRead.Username);
            return result;
        }

        public User Update(User updatedItem)
        {
            _db.Entry(updatedItem).State = EntityState.Modified;
            _db.SaveChanges();
            return updatedItem;
        }

        public void Delete(User itemToDelete)
        {
            _db.Users.Remove(itemToDelete);
            _db.SaveChanges();
        }

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
        ///     Gets the number of failed login attempts for the user account.
        /// </summary>
        /// <param name="username">The user-name.</param>
        /// <returns></returns>
        public int GetNoOfAttempts(string username)
        {
            return Read(new User
            {
                Username = username
            }).NoOfAttempts;
        }


        /// <summary>
        ///     Authenticates the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        /// <param name="password">The string password.</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
            if (_db.Users.SingleOrDefault(o => o.Username == username && o.Password == password)
                != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Blocks the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void Block(string username)
        {
            Read(new User
            {
                Username = username
            }).Blocked = true;
        }

        public bool DoeUserNameExist(string username)
        {
            bool ans;
            try
            {
                ans = _db.Users.Count(u => u.Username == username &&
                                           username != null) > 0;
            }
            catch
            {
                throw new Exception("A user with this user-name already exists.Please try again.");
            }
            return ans;
        }

        /// <summary>
        ///     Increments the number of failed login attempts.
        /// </summary>
        /// <param name="username">The user-name.</param>
        public void IncrementNoOfAttempts(string username)
        {
            Read(new User {Username = username}).NoOfAttempts++;
        }

        /// <summary>
        ///     Resets the number of failed login attempts.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void ResetNoOfAttempts(string username)
        {
            Read(new User {Username = username}).NoOfAttempts = 0;
        }

        /// <summary>
        ///     Unblock the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void UnBlockUser(string username)
        {
            Read(new User {Username = username}).Blocked = false;
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