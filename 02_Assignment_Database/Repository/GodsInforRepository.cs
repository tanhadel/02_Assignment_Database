

using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.ServiceRepository;

namespace _02_Assignment_Database.Repository
{
    internal class GodsInforRepository : Repo<GodsInforRepository>
    {
        public GodsInforRepository(DataContext context) : base(context)
        {
        }
    }
}
