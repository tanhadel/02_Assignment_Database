

using _02_Assignment_Database.Enitities;
using Microsoft.EntityFrameworkCore;

namespace _02_Assignment_Database.ConTexts;

internal class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Taha the one\OneDrive\Skrivbord\Databas\02_Assignment_Database\02_Assignment_Database\ConTexts\Vd_Database.mdf';Integrated Security=True;Connect Timeout=30");
    }
    public DbSet<AddressEntity> Address { get; set; }
    public DbSet<CompanyInfoEntity> CompanyInfo { get; set; }
    public DbSet<TruckInfoEntity> TruckInfo { get; set; }

}
