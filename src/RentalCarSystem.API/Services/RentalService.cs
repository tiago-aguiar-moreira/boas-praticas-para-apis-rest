using Microsoft.EntityFrameworkCore;
using RentalCarSystem.API.Repositories;
using RentalCarSystem.API.Repositories.Entities;
using RentalCarSystem.API.Services.Interfaces;

namespace RentalCarSystem.API.Services;

public class RentalService : IRentalService
{
    private readonly RentalCarDbContext _context;

    public RentalService(RentalCarDbContext context)
    {
        _context = context;
    }

    public IList<Rental> GetRentalsByPeriod(DateTime startDate, DateTime endDate)
        => [.. _context.Rental
            .Where(r => r.StartDate >= startDate && r.EndDate <= endDate)
            .Include(r => r.User)
            .Include(r => r.Car)];
}