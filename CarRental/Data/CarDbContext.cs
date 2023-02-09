using Microsoft.EntityFrameworkCore;

namespace CarRental.Models
{ 
    public class CarDbContext : DbContext
        {
            public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) {}
            public DbSet<CarModel> Cars { get; set; } = default!;
    }
    
}
