using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models;

public class Job
{
    [Required]
    [Column("job_id")]
    public int ID { get; set; }

    [Required]
    [Column("job_title")]
    public string Title { get; set; }

    [Column("min_salary", TypeName = "decimal(8,2)")]
    public decimal? MinSalary { get; set; }

    [Column("max_salary", TypeName = "decimal(8,2)")]
    public decimal? MaxSalary { get; set; }
}
