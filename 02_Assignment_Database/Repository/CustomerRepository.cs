

using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;
using _02_Assignment_Database.ServiceRepository;

namespace _02_Assignment_Database.Repository;

internal class CustomerRepository : Repo<CreateCustomerEntity>
{
    private readonly DataContext _context;
    public CustomerRepository(DataContext context) : base(context)
    {  
        _context = context;
    }

    public override Task<IEnumerable<CreateCustomerEntity>> GetAllAsync()
    {
        return base.GetAllAsync();
    }
}
