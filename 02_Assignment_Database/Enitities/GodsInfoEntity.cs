

using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class GodsInfoEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int TruckInfoId { get; set; }
    public TruckInfoEntity TruckInfoEntity { get; set; } = null!;
    public string Typeofgods { get; set; } = null!;

}
