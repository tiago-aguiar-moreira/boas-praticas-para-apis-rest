using Microsoft.EntityFrameworkCore;
using RentalCarSystem.API.Repositories.Entities;

namespace RentalCarSystem.API.Repositories;

public class RentalCarDbContext : DbContext
{
    public RentalCarDbContext(DbContextOptions<RentalCarDbContext> options) : base(options)
    {

    }

    public DbSet<User> User { get; set; }
    public DbSet<Car> Car { get; set; }
    public DbSet<Rental> Rental { get; set; }
}