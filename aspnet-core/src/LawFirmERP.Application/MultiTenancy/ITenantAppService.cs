using Abp.Application.Services;
using LawFirmERP.MultiTenancy.Dto;

namespace LawFirmERP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

