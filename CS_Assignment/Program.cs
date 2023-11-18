using CS_Assignment.Contexts;
using Microsoft.Extensions.DependencyInjection;
using CS_Assignment.Contexts

namespace CS_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var serviceColletion = new ServiceCollection();
            serviceColletion.AddDbContext<DataContext>(option => option.UseSqlSever(@""));
        }
    }
}