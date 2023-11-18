

using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class CreateCustomerEntity
{
    [Key]
    public int Id { get; set; }
    public string Titel { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string StreetName { get; set; } = null!;

    public string StreetNumber { get; set; } = null!;

    public int PostalCode { get; set; }

    public string City { get; set; } = null!;

    public string District { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Companyreg { get; set; } = null!;

    public int TaxNumber { get; set; }
    public int CompanyAddress { get; set; }
    public string RegNumber { get; set; } = null!;
    [Required]
    public string CountryregCode { get; set; } = null!;
    [Required]
    public string TruckColour { get; set; } = null!;
    [Required]
    public string Weight { get; set; } = null!;
    public string Typeofgods { get; set; } = null!;
}
