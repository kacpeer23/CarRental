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
    }
    private class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<CarRentalUser>
    {
        public void Configure(EntityTypeBuilder<CarRentalUser> builder)
        {
            builder.Property(x => x.Login).HasMaxLength(255);
            builder.Property(x => x.Password).HasMaxLength(255);
        }
    }

}
