using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models;

public class Dependent
{
    [Required]
    [Column("dependent_id")]
    public int ID { get; set; }

    [Required]
    [Column("first_name")]
    [StringLength(50)]
    public string FirstName { get; set; }

    [Required]
    [Column("last_name")]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [Column("relationship")]
    [StringLength(25)]
    public string Relationship { get; set; }

    [Required]
    [Column("employee_id")]
    public int EmployeeID { get; set; }
    public virtual Employee Employee { get; set; }
}
