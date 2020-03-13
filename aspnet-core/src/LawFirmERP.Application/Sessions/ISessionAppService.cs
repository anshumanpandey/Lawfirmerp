using System.Threading.Tasks;
using Abp.Application.Services;
using LawFirmERP.Sessions.Dto;

namespace LawFirmERP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
