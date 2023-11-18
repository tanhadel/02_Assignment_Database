

using Microsoft.EntityFrameworkCore;

namespace CS_Assignment.Contexts;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions <DataContext>options) : base(options)
    {
    }
}
