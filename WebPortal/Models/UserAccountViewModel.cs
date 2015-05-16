using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PagedList;

namespace WebPortal.Models
{
    public class UserAccountViewModel
    {
        [Required]
        [Display(Name = @"Full Name")]
        public string NameQuery { get; set; }

        [Display(Name = @"User Name", Order = 0)]
        public string UsernameQuery { get; set; }

        public IPagedList<UserListItemModel> UsersPagedList { get; set; }

    }

    public class RoleModel
    {
        public string Username { get; set; }
        [Display(Name = @"User Roles")]
        public IEnumerable<SelectListItem> UserRoles { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
    }

    public class UserListItemModel
    {
        [Required]
        [Display(Name = @"First Name")]
        public string FirstName { get; set; }

        [Display(Name = @"Initials (Optional)")]
        public string MiddleInitial { get; set; }

        [Required]
        [Display(Name = @"Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = @"Genders")]
        public int? GenderID { get; set; }

        [Required]
        [Display(Name = @"Date Of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = @"Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        [Display(Name = @"Town")]
        public int? TownID { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = @"Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = @"Invalid email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = @"Mobile Number")]
        public int Mobile { get; set; }

        [Display(Name = @"User Name", Order = 0)]
        public string Username { get; set; }

        [Display(Name = @"Failed Logins")]
        public int NoOfAttempts { get; set; }

        [Display(Name = @"Is Blocked")]
        public bool Blocked { get; set; }

        public SelectList Genders { get; set; }
        public SelectList Towns { get; set; }
        public SelectList Types { get; set; }
        public string GenderName { get; set; }
        public string TownName { get; set; }

        [Display(Name = @"User Roles")]
        public IEnumerable<SelectListItem> UserRoles { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Initials (Optional)")]
        public string MiddleInitial { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Genders")]
        public int? GenderID { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Town")]
        public int? TownID { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        public int Mobile { get; set; }

        [Required]
        [Display(Name = "User Name", Order = 0)]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }

        public SelectList Genders { get; set; }
        public SelectList Towns { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Security Token")]
        public string SecurityToken { get; set; }

        [Display(Name = "Remember Me")]
        public bool Remember { get; set; }
    }
}