using EmployeeWebAPI.Models;
using EmployeeWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers;

[Route("locations")]
[ApiController]
public class LocationController : ControllerBase
{
    public LocationService LocationService { get; }

	public LocationController(LocationService locationService)
	{
		LocationService = locationService;
	}

	// GET

	[HttpGet]
	public IEnumerable<Location> GetLocations() => LocationService.GetLocations();
}
