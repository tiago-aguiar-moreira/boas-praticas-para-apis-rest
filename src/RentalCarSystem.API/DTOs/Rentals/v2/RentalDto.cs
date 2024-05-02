namespace RentalCarSystem.API.DTOs.Rentals.v2;

public class RentalDto
{
    public int RentalId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalValue { get; set; }
    public int CarId { get; set; }
    public string Model { get; set; }
    public int? Year { get; set; }
    public string Color { get; set; }
    public double DailyPrice { get; set; }
    public bool Available { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public DateTime? BirthDate { get; set; }
}