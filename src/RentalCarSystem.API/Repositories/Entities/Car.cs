using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCarSystem.API.Repositories.Entities;

[Table("Cars")]
public class Car
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int? Year { get; set; }
    public string Color { get; set; }
    public double DailyPrice { get; set; }
    public bool Available { get; set; }
}