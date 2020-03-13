using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LawFirmERP.Configuration;

namespace LawFirmERP.Web.Host.Startup
{
    [DependsOn(
       typeof(LawFirmERPWebCoreModule))]
    public class LawFirmERPWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LawFirmERPWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LawFirmERPWebHostModule).GetAssembly());
        }
    }
}
