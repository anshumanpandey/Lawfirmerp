using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LawFirmERP.Controllers
{
    public abstract class LawFirmERPControllerBase: AbpController
    {
        protected LawFirmERPControllerBase()
        {
            LocalizationSourceName = LawFirmERPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
