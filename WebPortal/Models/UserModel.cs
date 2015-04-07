using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? GenderID { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public int? TownID { get; set; }
        public int? TypeID { get; set; }
        public bool Blocked { get; set; }
        public int NoOfAttempts { get; set; }
    }
}