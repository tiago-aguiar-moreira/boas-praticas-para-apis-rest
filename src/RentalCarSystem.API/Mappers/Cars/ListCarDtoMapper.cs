using RentalCarSystem.API.DTOs.Cars;
using RentalCarSystem.API.Repositories.Entities;

namespace RentalCarSystem.API.Mapper.Cars;

public static class ListCarDtoMapper
{
    public static ListCarDto MapToDtoList(this IList<Car>? cars) => new()
    {
        Car = cars is null ? [] : cars.Select(s => s.MapToDto()).ToList()
    };
}