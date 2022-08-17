using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class LocationService
{
	private readonly HRContext ctx;

	public LocationService(HRContext context)
	{
		ctx = context;
	}

	public IEnumerable<Location> GetLocations() => ctx.Locations.Include(j => j.Country);
}
