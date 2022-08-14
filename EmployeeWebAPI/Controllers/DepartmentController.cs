using EmployeeWebAPI.Models;
using EmployeeWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers;

[Route("departments")]
[ApiController]
public class DepartmentController : ControllerBase
{
    public DepartmentService DeptService { get; }
	public EmployeeService EmployeeService { get; set; }

	public DepartmentController(DepartmentService deptService, EmployeeService employeeService)
	{
		DeptService = deptService;
		EmployeeService = employeeService;
	}

	// GET

	[HttpGet]
	public IEnumerable<Department> GetDepartments() => DeptService.GetAllDepartments();

    [HttpGet]
    [Route("{id}")]
	public Department GetDepartment(int id) => DeptService.GetDepartment(id);

    [HttpGet]
    [Route("{id}/employees")]
	public IEnumerable<Employee> GetDepartmentEmployees(int id) => EmployeeService.GetAllEmployeesByDepartment(id);

	// POST

}
