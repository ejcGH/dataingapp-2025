using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API;

//class we are deriving from, using a primary constructor
public class AppDbContext(DbContextOptions options) : DbContext(options) 
{          // this will set name of table will be "Users" 
    public DbSet<AppUser> Users { get; set; }
}
