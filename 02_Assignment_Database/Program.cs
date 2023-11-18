using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;
using _02_Assignment_Database.MenuSeervice;

using _02_Assignment_Database.Service;
using _02_Assignment_Database.ServiceRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;


namespace _02_Assignment_Database
{
    public class Program
    {
        static async Task Main(string[] args)
        {


            var services = new ServiceCollection();
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Taha the one\OneDrive\Skrivbord\Databas\02_Assignment_Database\02_Assignment_Database\ConTexts\Vd_Database.mdf';Integrated Security=True"));
         
            var sl = services.BuildServiceProvider();
            var userMenu = sl.GetRequiredService<UserMenu>();
            await userMenu.BorderMainMenu();

            services.AddScoped<AddressEntity>();
            services.AddScoped<CreateCustomerEntity>();
            

            services.AddScoped<CustomerService>();

            services.AddScoped<CustomerMenu>();
            services.AddScoped<UserMenu>();

        }

    }
}




