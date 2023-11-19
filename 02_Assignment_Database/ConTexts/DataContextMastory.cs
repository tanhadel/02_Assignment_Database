
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Threading.Tasks;

namespace _02_Assignment_Database.ConTexts;

internal class DataContextMastory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<DataContext>();
            optionBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Taha the one\OneDrive\Skrivbord\Databas\02_Assignment_Database\CS_Assignment\Contexts\Database.mdf"";Integrated Security=True;Connect Timeout=30");
        return new DataContext(optionBuilder.Options); 
    }
}
