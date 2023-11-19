

//using _02_Assignment_Database.ConTexts;
//using _02_Assignment_Database.Enitities;
//using Microsoft.EntityFrameworkCore;
//using System.Diagnostics;

//namespace _02_Assignment_Database.ServiceRepository;

//internal class UserService
//{
//    private readonly DataContext _context;

//    public UserService(DataContext context)
//    {
//        _context = context;
//    }
//    public async Task<CompanyInfoEntity> CreateAsync(CompanyInfoEntity companyInfoEntity)
//    {
//        try
//        {
//            _context.Add(companyInfoEntity);
//            await _context.SaveChangesAsync();
//            return companyInfoEntity;

//        }
//        catch (Exception ex) { Debug.WriteLine(ex.Message); }
//        return null!;
//    }

//    public async Task<IEnumerable<CompanyInfoEntity>> ReadAsync()
//    {
//        try
//        {
//            return await _context.CompanyInfo.ToListAsync();


//        }
//        catch (Exception ex) { Debug.WriteLine(ex.Message); }
//        return null!;

//    }
//    public async Task<CompanyInfoEntity> UpdatAsync(CompanyInfoEntity companyInfo)
//    {
//        try
//        {
//            _context.Update(companyInfo);
//            await _context.SaveChangesAsync();
//            return companyInfo;



//        }
//        catch (Exception ex) { Debug.WriteLine(ex.Message); }
//        return null!;
//    }

//    public async Task<bool> DeleteAsync(CompanyInfoEntity companyInfo)
//    {
//        try
//        {
//            _context.Remove(companyInfo);
//            await _context.SaveChangesAsync();
//            return true;



//        }
//        catch (Exception ex) { Debug.WriteLine(ex.Message); }
//        return false!;
//    }



//}


