using RentalCarSystem.API.Repositories.Entities;

namespace RentalCarSystem.API.Services.Interfaces;

public interface ICarService
{
    IList<Car> GetAll();
    Car? GetById(int id);
    void Create(Car car);
}