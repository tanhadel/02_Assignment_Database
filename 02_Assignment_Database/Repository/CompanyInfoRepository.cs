

using _02_Assignment_Database.ConTexts;


namespace _02_Assignment_Database.Repositories;


internal class CompanyInfoRepository : Repo<CompanyInfoRepository>
{
    public CompanyInfoRepository(DataContext context) : base(context)
    {
    }
}




