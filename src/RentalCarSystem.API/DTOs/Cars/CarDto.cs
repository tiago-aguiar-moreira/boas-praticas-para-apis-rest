namespace RentalCarSystem.API.DTOs.Cars;

public class CarDto
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int? Year { get; set; }
    public string Color { get; set; }
    public double DailyPrice { get; set; }
    public bool Available { get; set; }
}