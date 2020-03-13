using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LawFirmERP.Authorization;

namespace LawFirmERP
{
    [DependsOn(
        typeof(LawFirmERPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LawFirmERPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LawFirmERPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LawFirmERPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
