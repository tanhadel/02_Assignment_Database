
using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;

namespace _02_Assignment_Database.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }

   
}
