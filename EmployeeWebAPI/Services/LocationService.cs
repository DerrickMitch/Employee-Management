using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class LocationService
{
    public EMDatabase Database { get; }

	public LocationService(EMDatabase database)
	{
		Database = database;
	}

	public IEnumerable<Location> GetLocations() => Database.Locations.Include(j => j.Country);
}
