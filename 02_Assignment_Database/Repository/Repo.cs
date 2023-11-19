

using _02_Assignment_Database.ConTexts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

///*namespace _02_Assignment_Database.ServiceRepository*/;
namespace _02_Assignment_Database.Repositories;

internal abstract class Repo <TEntity> where TEntity : class
{



    private readonly DataContext _context;
    protected Repo(DataContext context)
    {
        _context = context;

    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        try
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return entity ?? null!;

    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {

        try
        {

            var enttiy = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
            return enttiy ?? null!;
        }

        catch (Exception ex ) { Debug.WriteLine(ex.Message); }

        return null!;

      

    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        catch (Exception ex ) { Debug.WriteLine(ex.Message); }
        return Enumerable.Empty<TEntity>();
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity ?? null!;
        }
        catch (Exception ex ){ Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
    {
        var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        if (entity != null)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;

        }
        return false;

    }
    public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        try
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }
        catch (Exception ex ) { Debug.WriteLine(ex.Message); 
            return false; }

    }
}


 
    