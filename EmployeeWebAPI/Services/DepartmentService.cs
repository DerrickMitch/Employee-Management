using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeWebAPI.Services;

public class DepartmentService
{
	public IWebHostEnvironment WebHostEnvironment { get; }

	private readonly HRContext ctx;

	public DepartmentService(IWebHostEnvironment webHostEnvironment, HRContext context)
	{
		WebHostEnvironment = webHostEnvironment;
		ctx = context;
	}

	public IEnumerable<Department> GetAllDepartments()
	{
		return ctx.Departments;
	}

	public Department GetDepartment(int id)
	{
		return ctx.Departments
			.Include(d => d.Location)
			.First(d => d.ID == id);
	}
}
