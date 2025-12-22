using Application.Interfaces;
using Application.Service;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;


[ApiController]
[Route("api/[controller]")]
public class AppDomainController: ControllerBase 
{
    private readonly AppDomainService _appDomainService;
    
    public AppDomainController(AppDomainService appDomainService)
    {
        _appDomainService = appDomainService;
    }
    

    [HttpGet]
    public async Task<IActionResult> GetAppDomains()
    {
        var list = await _appDomainService.getAllAppDomain();
        return Ok(list);
    }
    
}