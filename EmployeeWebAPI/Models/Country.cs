using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models;

public class Country
{
    [Required]
    [StringLength(2)]
    [Column("country_id")]
    public string ID { get; set; }

    [StringLength(40)]
    [Column("country_name")]
    public string? Name { get; set; }

    [Required]
    [Column("region_id")]
    public int RegionID { get; set; }
    public virtual Region Region { get; set; }
}
