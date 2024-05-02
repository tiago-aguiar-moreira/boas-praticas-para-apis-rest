using RentalCarSystem.API.DTOs.Cars;
using RentalCarSystem.API.Repositories.Entities;

namespace RentalCarSystem.API.Mapper.Cars;

public static class CarDtoMapper
{
    public static CarDto MapToDto(this Car? car) => new()
    {
        Id = car.Id,
        Model = car.Model,
        Year = car.Year,
        Color = car.Color,
        DailyPrice = car.DailyPrice,
        Available = car.Available
    };

    public static Car MapToEntity(this CarDto? car) => new()
    {
        Id = car.Id,
        Model = car.Model,
        Year = car.Year,
        Color = car.Color,
        DailyPrice = car.DailyPrice,
        Available = car.Available
    };
}