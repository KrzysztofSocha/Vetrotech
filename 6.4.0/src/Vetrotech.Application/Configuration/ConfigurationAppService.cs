using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Vetrotech.Configuration.Dto;

namespace Vetrotech.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VetrotechAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
