using RentalCarSystem.API.Repositories;
using RentalCarSystem.API.Repositories.Entities;
using RentalCarSystem.API.Services.Interfaces;

namespace RentalCarSystem.API.Services;

public class CarService : ICarService
{
    private readonly RentalCarDbContext _context;

    public CarService(RentalCarDbContext context)
    {
        _context = context;
    }

    public void Create(Car car)
    {
        _context.Car.Add(car);
        _context.SaveChanges();
    }

    public IList<Car> GetAll() => [.. _context.Car];

    public Car? GetById(int id) => _context.Car.FirstOrDefault(f => id == f.Id);
}