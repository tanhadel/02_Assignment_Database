

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace _02_Assignment_Database.Enitities;

internal class CompanyInfoEntity
{
    [Key]
    public int Id { get; set; }
    public string CompanyName { get; set; } = null!;

    public string Companyreg { get; set; } = null!;

    public int TaxNumber { get; set; }
    public string CompanyAddress { get; set; } = null!;

}
