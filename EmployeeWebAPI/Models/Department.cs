using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models;

public class Department
{
    [Required]
    [Column("department_id")]
    public int ID { get; set; }

    [Required]
    [StringLength(30)]
    [Column("department_name")]
    public string Name { get; set; }

    [Column("location_id")]
    public int? LocationID { get; set; }
    public virtual Location? Location { get; set; }
}
