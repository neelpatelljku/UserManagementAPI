using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserManagementAPI.Models;  // Import the Models namespace

namespace UserManagementAPI.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  // Represents the Users table
    }
}
