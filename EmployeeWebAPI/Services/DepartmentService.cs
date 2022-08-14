using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeWebAPI.Services;

public class DepartmentService
{
	public IWebHostEnvironment WebHostEnvironment { get; }

	public EMDatabase Database { get; }

	public DepartmentService(IWebHostEnvironment webHostEnvironment, EMDatabase database)
	{
		WebHostEnvironment = webHostEnvironment;
		Database = database;
	}

	public IEnumerable<Department> GetAllDepartments()
	{
		return Database.Departments;
	}

	public Department GetDepartment(int id)
	{
		return Database.Departments
			.Include(d => d.Location)
			.First(d => d.ID == id);
	}
}
