using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models;

public class Location
{
    [Required]
    [Column("location_id")]
    public int ID { get; set; }
    
    [Column("street_address")]
    [StringLength(40)]
    public string? StreetAddress { get; set; }

    [Column("postal_code")]
    [StringLength(12)]
    public string? PostalCode { get; set; }

    [Required]
    [Column("city")]
    [StringLength(30)]
    public string City { get; set; }

    [Column("state_province")]
    [StringLength(25)]
    public string? StateProvince { get; set; }

    [Required]
    [Column("country_id")]
    [StringLength(2)]
    public string CountryID { get; set; }
    public virtual Country Country { get; set; }
}
