using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class JobService
{
    public EMDatabase Database { get; }

	public JobService(EMDatabase database)
	{
		Database = database;
	}

	public IEnumerable<Job> GetJobs() => Database.Jobs;

	public Job GetJob(int id) => Database.Jobs.First(j => j.ID == id);
}
