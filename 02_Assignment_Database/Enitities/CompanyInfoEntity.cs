
using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class CompanyInfoEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int AddressId { get; set; }
    public AddressEntity Address { get; set; } = null!;
    public string CompanyName { get; set; }=null!;
    [Required]
    public string Companyreg { get; set;} =null!;
    [Required]
    public int TaxNumber { get; set;} 

}
