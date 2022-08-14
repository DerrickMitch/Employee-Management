using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models;

public class Region
{
    [Required]
    [Column("region_id")]
    public int ID { get; set; }

    [Column("region_name")]
    [StringLength(25)]
    public string? Name { get; set; }
}
