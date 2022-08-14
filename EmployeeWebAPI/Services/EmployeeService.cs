using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class EmployeeService
{
	public EMDatabase Database { get; }

	public DependentService DependentService { get; set; }

	public EmployeeService(EMDatabase db, DependentService dependentService)
	{
		Database = db;
		DependentService = dependentService;
	}

	public IEnumerable<Employee> GetAllEmployees()
	{
        return Database.Employees;
    }

	public IEnumerable<Employee> GetAllEmployeesByDepartment(int departmentID)
	{
		return Database.Employees
			.Include(e => e.Department)
			.Where(e => e.DepartmentID == departmentID);
	}

	public Employee GetEmployee(int id)
	{
		return Database.Employees
			.Include(e => e.Department)
			.Include(e => e.Manager)
			.Include(e => e.Job)
			.First(e => e.ID == id);
	}
}
