using CarRental.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Data;

public class CarRentalContext : IdentityDbContext<CarRentalUser>
{
    public CarRentalContext(DbContextOptions<CarRentalContext> options)
        : base(options)
    {
    }
    protected CarRentalContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.

        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData
           (
           new IdentityRole()
           {
               Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
               Name = "Administrator",
               ConcurrencyStamp = "1",
               NormalizedName = "ADMINISTRATOR"
           }
           );
        var hashing = new PasswordHasher<CarRentalUser>();
        builder.Entity<CarRentalUser>().HasData
            (
            new CarRentalUser()
            {
                Id = "d57a3861-3c43-4ed0-86c1-c6f604a3afe7",
                EmailConfirmed = true,
                Email = "kacper.kowalski@gmail.com",
                NormalizedEmail = "KACPER.KOWALSKI@GMAIL.COM",
                LockoutEnabled = true,
                UserName = "kacper.kowalski@gmail.com",
                NormalizedUserName = "kacper.kowalski@gmail.com",
                Password = "Admin123!",
                PasswordHash = hashing.HashPassword(null, "Admin123!")
            }
            );
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "d57a3861-3c43-4ed0-86c1-c6f604a3afe7"
            }
            );
    }
    private class ApplicationUserEntityConfiguration :
IEntityTypeConfiguration<CarRentalUser>
    {
        public void Configure(EntityTypeBuilder<CarRentalUser> builder)
        {
            builder.Property(x => x.Email).HasMaxLength(255);
            builder.Property(x => x.Password).HasMaxLength(255);
        }
    }

}
