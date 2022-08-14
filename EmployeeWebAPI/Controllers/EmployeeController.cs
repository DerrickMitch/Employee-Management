using EmployeeWebAPI.Models;
using EmployeeWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers;

[Route("employees")]
[ApiController]
public class EmployeeController : ControllerBase
{
	public EmployeeService EmployeeService { get; }
	public DependentService DependentService { get; set; }

	public EmployeeController(EmployeeService employeeService, DependentService dependentService)
	{
		EmployeeService = employeeService;
		DependentService = dependentService;
	}

	// GET
	
	[HttpGet]
	public IEnumerable<Employee> GetAllEmployees() => EmployeeService.GetAllEmployees();


    [HttpGet]
    [Route("{id}")]
    public Employee GetEmployee(int id) => EmployeeService.GetEmployee(id);

	[HttpGet]
	[Route("{id}/dependents")]
	public IEnumerable<Dependent> GetEmployeeDependets(int id) => DependentService.GetEmployeeDependents(id);
}
