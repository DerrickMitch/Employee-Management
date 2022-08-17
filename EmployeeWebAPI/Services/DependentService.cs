using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class DependentService
{
	private readonly HRContext ctx;

	public DependentService(HRContext context)
	{
		ctx = context;
	}

	public IEnumerable<Dependent> GetEmployeeDependents(int id) => ctx.Dependents.Where(d => d.EmployeeID == id);
}
