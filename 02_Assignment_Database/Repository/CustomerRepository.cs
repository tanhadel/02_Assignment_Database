

using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;


namespace _02_Assignment_Database.Repositories;


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
