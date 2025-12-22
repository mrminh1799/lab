using Application.Interfaces;
using AppDomain = Domain.Entities.AppDomain;
namespace Application.Service;


public class AppDomainService
{
    private readonly IAppDomainRepository _appdomainRepository;

    public AppDomainService(IAppDomainRepository appdomainRepository)
    {
        this._appdomainRepository = appdomainRepository;
    }
    
    
    public async Task<IEnumerable<AppDomain>> getAllAppDomain()
    {
        return await _appdomainRepository.GetAllAsync();

    }
}