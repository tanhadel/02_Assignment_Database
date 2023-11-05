
using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class TruckInfoEntity
{
    [Key]  
    public int Id { get; set; }
    [Required]
    public int CompanyId { get; set; } 
    public CompanyInfoEntity Company { get; set; } = null!;
    public string RegNumber { get; set; } = null!;
    [Required]
    public string CountryregCode { get; set; } = null!;
    [Required]
    public string TruckColour { get; set; } = null!;
    [Required]
    public string Weight {  get; set; } = null!;


}
