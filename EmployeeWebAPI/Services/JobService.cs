using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services;

public class JobService
{
	private readonly HRContext ctx;

	public JobService(HRContext context)
	{
		ctx = context;
	}

	public IEnumerable<Job> GetJobs() => ctx.Jobs;

	public Job GetJob(int id) => ctx.Jobs.First(j => j.ID == id);
}
