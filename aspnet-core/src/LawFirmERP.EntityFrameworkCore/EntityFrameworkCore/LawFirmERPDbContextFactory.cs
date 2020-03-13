using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LawFirmERP.Configuration;
using LawFirmERP.Web;

namespace LawFirmERP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LawFirmERPDbContextFactory : IDesignTimeDbContextFactory<LawFirmERPDbContext>
    {
        public LawFirmERPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LawFirmERPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LawFirmERPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LawFirmERPConsts.ConnectionStringName));

            return new LawFirmERPDbContext(builder.Options);
        }
    }
}
