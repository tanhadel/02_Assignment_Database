

using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class AddressEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public AddressEntity Address { get; set; } = null!;
    public string SreertName { get; set; } = null!;
    [Required]
    public string StreetNumber { get; set; }= null!;
    [Required]
    public int PostalCode { get; set; } 
    [Required]
    public string City { get; set; }= null!;
    [Required]
    public string District { get; set; }=null!;
    [Required]
    public string Country { get; set; }=null!;


    
}
