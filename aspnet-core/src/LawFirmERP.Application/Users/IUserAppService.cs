using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LawFirmERP.Roles.Dto;
using LawFirmERP.Users.Dto;

namespace LawFirmERP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
