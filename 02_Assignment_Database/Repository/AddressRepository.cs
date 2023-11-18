
using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;
using _02_Assignment_Database.ServiceRepository;

namespace _02_Assignment_Database.Repositories;

internal class AddressRepository : Repo<AddressRepository>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }

   
}
