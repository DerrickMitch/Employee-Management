using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class DependentService
{
    public EMDatabase Database { get; set; }

	public DependentService(EMDatabase database)
	{
		Database = database;
	}

	public IEnumerable<Dependent> GetEmployeeDependents(int id) => Database.Dependents.Where(d => d.EmployeeID == id);
}
