using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using RentalCarSystem.API.DTOs.Cars;
using RentalCarSystem.API.Exntensions;
using RentalCarSystem.API.Mapper.Cars;
using RentalCarSystem.API.Services.Interfaces;

namespace RentalCarSystem.API.Controllers;

[ApiVersion(1)]
[Route("api/v{v:apiVersion}/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    [HttpGet(Name = nameof(GetAll))]
    public IActionResult GetAll([FromServices] ICarService carService)
    {
        try
        {
            var cars = carService.GetAll();

            return cars is not null
                ? Ok(ApiResponse<ListCarDto>.CreateResponse(cars.MapToDtoList()))
                : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<ListCarDto>.CreateResponse(ex));
        }
    }

    [HttpGet("{id}", Name = nameof(GetById))]
    public IActionResult GetById([FromServices] ICarService carService, int id)
    {
        try
        {
            var car = carService.GetById(id);

            return car is not null
                ? Ok(ApiResponse<CarDto?>.CreateResponse(car.MapToDto()))
                : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<CarDto?>.CreateResponse(ex));
        }
    }

    [HttpPost(Name = nameof(Create))]
    public IActionResult Create([FromServices] ICarService carService, CarDto newCar)
    {
        try
        {
            var newEntity = newCar.MapToEntity();

            carService.Create(newEntity);

            return newEntity.Id > 0 ? Created() : BadRequest();
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<CarDto>.CreateResponse(ex));
        }
    }
}
