using _02_Assignment_Database.ConTexts;


namespace _02_Assignment_Database.Repositories;

internal class DriverInfoRepository : Repo<DriverInfoRepository>
{
    public DriverInfoRepository(DataContext context) : base(context)
    {
    }
}