namespace RentalCarSystem.API.DTOs.Rentals.v1;

public class RentalDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalValue { get; set; }
    public UserDto? User { get; set; }
    public CarDto? Car { get; set; }
}