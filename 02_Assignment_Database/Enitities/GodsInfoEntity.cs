

using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class GodsInfoEntity

{
    [Key]
     public int Id { get; set; }
    public string Typeofgods { get; set; } = null!;
}
