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

        var adminId = Guid.NewGuid().ToString();
        var adminRoleId = Guid.NewGuid().ToString();
        var userRoleId = Guid.NewGuid().ToString();
        
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5", 
                UserName = "adminuser", 
                NormalizedUserName = "ADMINUSER", 
                Email = "adminuser", 
                NormalizedEmail = "ADMINUSER", 
                EmailConfirmed = true, 
                PasswordHash = hasher.HashPassword(null, "noKilladmin2024!"), 
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }
        );

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                Name = "Admin",
                NormalizedName = "Admin",
                ConcurrencyStamp = "1"
            }
        );
        
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                Name = "User",
                NormalizedName = "User",
                ConcurrencyStamp = "2"
            }
        );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
               UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
               RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
            }
        );

    }
}