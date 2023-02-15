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

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN".ToUpper() },
            new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER".ToUpper() }
        );
        var hasher = new PasswordHasher<IdentityUser>();

        builder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = "ef393d67-82d7-4049-8015-2a1b24a90c69",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Test123!")

            },
            new IdentityUser
            {
                Id = "9b2bbed4-4753-445c-b47e-4d0eaa925455",
                UserName = "nowak@gmail.com",
                NormalizedUserName = "NOWAK@GMAIL.COM",
                Email = "nowak@gmail.com",
                NormalizedEmail = "NOWAK@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Test123!")
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
            builder.Property(x => x.ConfirmPassword).HasMaxLength(255);
        }
    }

}
