namespace Application.Interfaces;

using AppDomain = Domain.Entities.AppDomain;
public interface IAppDomainRepository
{
    Task<IEnumerable<AppDomain>> GetAllAsync();
    Task<AppDomain?> GetByIdAsync(int id);
    Task<AppDomain> CreateAsync(AppDomain appDomain);
    Task<AppDomain> UpdateAsync(AppDomain appDomain);
    Task DeleteAsync(int id);
    
}