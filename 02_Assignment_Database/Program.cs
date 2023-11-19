using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;
using _02_Assignment_Database.MenuSeervice;
using _02_Assignment_Database.Repositories;
using _02_Assignment_Database.Service;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace _02_Assignment_Database
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            // Registrera tjänster
            services.AddScoped<AddressRepository>();
            services.AddScoped<CustomerRepository>();
            services.AddScoped<CompanyInfoRepository>();
            services.AddScoped<DriverInfoRepository>();
            services.AddScoped<GodsInforRepository>();
            services.AddScoped<TruckInfoRepository>();

            services.AddScoped<CustomerService>();
            services.AddScoped<CustomerMenu>();
            services.AddScoped<UserMenu>();

            // Lägg till DbContext-tjänsten
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Taha the one\OneDrive\Skrivbord\Databas\02_Assignment_Database\02_Assignment_Database\ConTexts\Vd_Database.mdf';Integrated Security=True"));

            var serviceProvider = services.BuildServiceProvider();

            // Hämta UserMenu-tjänsten
            var userMenu = serviceProvider.GetRequiredService<UserMenu>();
            await userMenu.BorderMainMenu();
        }


    }

    //public void ConfigureServices(IServiceCollection services)
    //{
    //    services.AddScoped<UserMenu>();
    //}

}




