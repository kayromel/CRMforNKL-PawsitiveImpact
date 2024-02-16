using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace No_Kill_Inventory.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=data/app.db");
    }
    
    public DbSet<Item> Items { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var hasher = new PasswordHasher<IdentityUser>();

        var adminID = Guid.NewGuid().ToString();
        var securityStamp = Guid.NewGuid().ToString();
        
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser()
            {
                Id = adminID, 
                UserName = "adminuser", 
                NormalizedUserName = "ADMINUSER", 
                Email = "adminuser", 
                NormalizedEmail = "ADMINUSER", 
                EmailConfirmed = true, 
                PasswordHash = hasher.HashPassword(null, "noKilladmin2024!"), 
                SecurityStamp = securityStamp,
                ConcurrencyStamp = string.Empty,
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }
        );
    }
}