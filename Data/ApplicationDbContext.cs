using Bowel_API.Models;
using Microsoft.EntityFrameworkCore;


namespace Bowel_API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}
