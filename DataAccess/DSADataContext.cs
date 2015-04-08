using System;
using System.Data.Entity;
using DataAccess.EntityModel;

namespace DataAccess
{
    public class DsaDataContext : DbContext
    {
        public DsaDataContext()
            : base("name=DefaultConnection")
        {
            //connection with highest database permissions
        }

        public DsaDataContext(String connectionString)
            : base("name=" + connectionString)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}