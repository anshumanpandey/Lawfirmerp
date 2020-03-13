using Abp.Authorization;
using LawFirmERP.Authorization.Roles;
using LawFirmERP.Authorization.Users;

namespace LawFirmERP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
