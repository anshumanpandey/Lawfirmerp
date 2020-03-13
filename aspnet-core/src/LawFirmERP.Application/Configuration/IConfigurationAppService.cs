using System.Threading.Tasks;
using LawFirmERP.Configuration.Dto;

namespace LawFirmERP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
