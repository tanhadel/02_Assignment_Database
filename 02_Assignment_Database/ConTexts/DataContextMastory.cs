
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Threading.Tasks;

namespace _02_Assignment_Database.ConTexts;

internal class DataContextMastory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<DataContext>();
            optionBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Taha the one\OneDrive\Skrivbord\Databas\02_Assignment_Database\02_Assignment_Database\ConTexts\Vd_Database.mdf';Integrated Security=True");
        return new DataContext(optionBuilder.Options); 
    }
}
