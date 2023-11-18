

using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.ServiceRepository;
namespace _02_Assignment_Database.Repositories;


    internal class TruckInfoRepository : Repo<TruckInfoRepository>
    {
        public TruckInfoRepository(DataContext context) : base(context)
        {
        }
    }

