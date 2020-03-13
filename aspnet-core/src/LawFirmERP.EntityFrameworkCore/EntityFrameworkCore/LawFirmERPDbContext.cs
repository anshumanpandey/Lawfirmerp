using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LawFirmERP.Authorization.Roles;
using LawFirmERP.Authorization.Users;
using LawFirmERP.MultiTenancy;

namespace LawFirmERP.EntityFrameworkCore
{
    public class LawFirmERPDbContext : AbpZeroDbContext<Tenant, Role, User, LawFirmERPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LawFirmERPDbContext(DbContextOptions<LawFirmERPDbContext> options)
            : base(options)
        {
        }
    }
}
