using Application.Interfaces;
using Infrastructure.data;
using Microsoft.EntityFrameworkCore;
using AppDomain =  Domain.Entities.AppDomain;

namespace Infrastructure.Repository.Iplm;

public class AppDomainRepository: IAppDomainRepository
{
    private readonly ApplicationDBContext _context;
    
    
    public AppDomainRepository(ApplicationDBContext context)
    {
        this._context = context;
    }
    
    public async Task<IEnumerable<AppDomain>> GetAllAsync()
    {
        return await _context.AppDomains.ToListAsync();
    }

    public async Task<AppDomain> GetByIdAsync(int id)
    {
        return await _context.AppDomains.FindAsync(id);
    }

    public async Task<AppDomain> CreateAsync(AppDomain appDomain)
    {
        var entityEntry = _context.AppDomains.Add(appDomain);
        await _context.SaveChangesAsync();
        appDomain.Id = entityEntry.Entity.Id;
        return appDomain;
    }

    public async Task<AppDomain> UpdateAsync(AppDomain appDomain)
    {
        _context.Update(appDomain);
        await _context.SaveChangesAsync();
        return appDomain;
    }

    public async Task DeleteAsync(int id)
    {
        var appDomain = await _context.AppDomains.FindAsync(id);
        if (appDomain != null)
        {
            _context.AppDomains.Remove(appDomain);
            await _context.SaveChangesAsync();
        }
    }
}