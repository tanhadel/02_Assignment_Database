

using _02_Assignment_Database.ConTexts;

namespace _02_Assignment_Database.Repositories;


    internal class TruckInfoRepository : Repo<TruckInfoRepository>
    {
        public TruckInfoRepository(DataContext context) : base(context)
        {
        }
    }

