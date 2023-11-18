

using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.ServiceRepository;

namespace _02_Assignment_Database.Repository;

internal class CompanyInfoRepository : Repo<CompanyInfoRepository>
{
    public CompanyInfoRepository(DataContext context) : base(context)
    {
    }
}




