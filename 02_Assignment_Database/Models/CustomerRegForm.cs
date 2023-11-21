

using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Models;

internal class CustomerRegForm
{
 
    public string Titel { get; set; } = null!;
    [Required]
  
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required]
    public int PhoneNumber { get; set; }
    [Required]
    public string StreetName { get; set; } = null!;
    [Required]
    public string StreetNumber { get; set; } = null!;
    [Required]
    public int PostalCode { get; set; }
    [Required]
    public string City { get; set; } = null!;
    [Required]
    public string District { get; set; } = null!;
    [Required]
    public string Country { get; set; } = null!;
    [Required]
    public int Address { get; set; }
    [Required]
    public string CompanyName { get; set; } = null!;
    [Required]
    public string Companyreg { get; set; } = null!;
    [Required]
    public int TaxNumber { get; set; }
    [Required]
    public int CompanyAddress { get; set; }
    [Required]
    public string RegNumber { get; set; } = null!;
    [Required]
    public string CountryregCode { get; set; } = null!;
    [Required]
    public string TruckColour { get; set; } = null!;
    [Required]
    public string Weight { get; set; } = null!;
    [Required]
    public string Typeofgods { get; set; } = null!;
}


