using RentalsV1 = RentalCarSystem.API.DTOs.Rentals.v1;
using RentalsV2 = RentalCarSystem.API.DTOs.Rentals.v2;
using RentalCarSystem.API.Repositories.Entities;

namespace RentalCarSystem.API.Mapper.Rentals;

public static class ListRentalDtoMapper
{
    public static RentalsV1.ListRentalDto MapToDtoListV1(this IList<Rental>? rentals) => new()
    {
        Rental = rentals is null ? [] : rentals
            .Select(s => new RentalsV1.RentalDto()
            {
                Id = s.Id,
                UserId = s.UserId,
                CarId = s.CarId,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                TotalValue = s.TotalValue,
                User = MapUserToDto(s.User),
                Car = MapCarToDto(s.Car)
            }).ToList()
    };

    public static RentalsV2.ListRentalDto MapToDtoListV2(this IList<Rental>? rentals) => new()
    {
        Rental = rentals is null ? [] : rentals
            .Select(s => new RentalsV2.RentalDto()
            {
                RentalId = s.Id,
                UserId = s.UserId,
                CarId = s.CarId,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                TotalValue = s.TotalValue,
                Model = s.Car.Model,
                Year = s.Car.Year,
                Color = s.Car.Color,
                DailyPrice = s.Car.DailyPrice,
                Available = s.Car.Available,
                UserName = s.User.Name,
                UserEmail = s.User.Email,
                BirthDate = s.User?.BirthDate
            }).ToList()
    };

    private static RentalsV1.UserDto? MapUserToDto(User? user)
    {
        if (user is null)
            return null;

        return new RentalsV1.UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Password = user.Password,
            BirthDate = user.BirthDate,
            Street = user.Street,
            Number = user.Number,
            Complement = user.Complement,
            City = user.City,
            State = user.State,
            Country = user.Country
        };
    }

    private static RentalsV1.CarDto? MapCarToDto(Car? car)
    {
        if (car is null)
            return null;

        return new RentalsV1.CarDto
        {
            Id = car.Id,
            Model = car.Model,
            Year = car.Year,
            Color = car.Color,
            DailyPrice = car.DailyPrice,
            Available = car.Available
        };
    }
}