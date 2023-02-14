using CarRental.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Models
{ 
    public class CarDbContext : CarRentalContext
        {
            public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) {}
            public DbSet<CarModel> Cars { get; set; } = default!;
            public DbSet<ClientModel> Clients { get; set; } = default!;
    }
    
}
