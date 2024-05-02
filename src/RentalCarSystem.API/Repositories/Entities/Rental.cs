using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCarSystem.API.Repositories.Entities;

[Table("Rentals")]
public class Rental
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalValue { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
    public int CarId { get; set; }
    public required Car Car { get; set; }
}