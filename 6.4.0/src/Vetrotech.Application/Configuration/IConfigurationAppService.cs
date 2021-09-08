using System.Threading.Tasks;
using Abp.Application.Services;
using Vetrotech.Configuration.Dto;

namespace Vetrotech.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}