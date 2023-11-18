

using _02_Assignment_Database.Enitities;
using Microsoft.EntityFrameworkCore;

namespace _02_Assignment_Database.ConTexts;

internal class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<AddressEntity> Address { get; set; }
    public DbSet<CreateCustomerEntity> CreateCustomer { get; set; }
    public DbSet<CompanyInfoEntity> CompanyInfo { get; set; }
    public DbSet<DriverInfoEntity> DriverInfo { get; set; }
    public DbSet<GodsInfoEntity> GodsInfo { get; set; }
    public DbSet<TruckInfoEntity> TruckInfoEntities { get; set; }
   
    



}


    
   

        