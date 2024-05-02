using RentalCarSystem.API.Repositories.Entities;

namespace RentalCarSystem.API.Services.Interfaces;

public interface IRentalService
{
    IList<Rental> GetRentalsByPeriod(DateTime startDate, DateTime endDate);
}