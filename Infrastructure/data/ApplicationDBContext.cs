using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using AppDomain = Domain.Entities.AppDomain;
using Thread = Domain.Entities.Thread;

namespace Infrastructure.data;

public class ApplicationDBContext: DbContext
{
    public DbSet<AppDomain>  AppDomains { get; set; }
    public DbSet<Thread>  Threads { get; set; }
    public DbSet<ThreadMember>  ThreadMembers { get; set; }
    
    
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
    {
    }
    
    
}