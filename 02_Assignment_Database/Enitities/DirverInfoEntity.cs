

using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class DirverInfoEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int AddressId { get; set; }
    [Required]
    public string Titel { get; set; } = null!;
    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; }= null!;
    [Required]
    public int PhoneNumber { get; set; }




}
