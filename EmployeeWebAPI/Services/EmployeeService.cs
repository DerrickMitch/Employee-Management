using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class EmployeeService
{
	private readonly HRContext ctx;

	public DependentService DependentService { get; set; }

	public EmployeeService(HRContext context, DependentService dependentService)
	{
		ctx = context;
		DependentService = dependentService;
	}

	public IEnumerable<Employee> GetAllEmployees()
	{
        return ctx.Employees;
    }

	public IEnumerable<Employee> GetAllEmployeesByDepartment(int departmentID)
	{
		return ctx.Employees
			.Include(e => e.Department)
			.Where(e => e.DepartmentID == departmentID);
	}

	public Employee GetEmployee(int id)
	{
		return ctx.Employees
			.Include(e => e.Department)
			.Include(e => e.Manager)
			.Include(e => e.Job)
			.First(e => e.ID == id);
	}
}
