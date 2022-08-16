using Microsoft.EntityFrameworkCore;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Services;

public class EMDatabaseService : DbContext
{
    // Properties
    public DbSet<Employee> Employees { get; set; }

    public DbSet<Country> Countries { get; set; }

    public DbSet<Department> Departments { get; set; }

    public DbSet<Job> Jobs { get; set; }

    public DbSet<Location> Locations { get; set; }

    public DbSet<Region> Regions { get; set; }

    public DbSet<Dependent> Dependents { get; set; }

    // Configure connection to DB
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=EmployeeManagement; Integrated Security=true;"); // connection string
    }


}
