using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using RentalsV1 = RentalCarSystem.API.DTOs.Rentals.v1;
using RentalsV2 = RentalCarSystem.API.DTOs.Rentals.v2;
using RentalCarSystem.API.Exntensions;
using RentalCarSystem.API.Mapper.Rentals;
using RentalCarSystem.API.Services.Interfaces;

namespace RentalCarSystem.API.Controllers;

[ApiController]
[ApiVersion(1)]
[ApiVersion(2)]
[Route("api/v{v:apiVersion}/[controller]")]
public class RentalController : ControllerBase
{
    [MapToApiVersion(1)]
    [HttpGet("{startDate}/{endDate}", Name = nameof(GetRentalsByPeriodV1))]
    public IActionResult GetRentalsByPeriodV1([FromServices] IRentalService rentalService, DateTime startDate, DateTime endDate)
    {
        try
        {
            var rentals = rentalService.GetRentalsByPeriod(startDate, endDate);

            return rentals is not null
                ? Ok(ApiResponse<RentalsV1.ListRentalDto>.CreateResponse(rentals.MapToDtoListV1()))
                : BadRequest();
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<RentalsV1.ListRentalDto>.CreateResponse(ex));
        }
    }

    [MapToApiVersion(2)]
    [HttpGet("{startDate}/{endDate}", Name = nameof(GetRentalsByPeriodV2))]
    public IActionResult GetRentalsByPeriodV2([FromServices] IRentalService rentalService, DateTime startDate, DateTime endDate)
    {
        try
        {
            var rentals = rentalService.GetRentalsByPeriod(startDate, endDate);

            return rentals is not null
                ? Ok(ApiResponse<RentalsV2.ListRentalDto>.CreateResponse(rentals.MapToDtoListV2()))
                : BadRequest();
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<RentalsV2.ListRentalDto>.CreateResponse(ex));
        }
    }
}