using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Modul_202107.Configuration.Dto;

namespace Modul_202107.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Modul_202107AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
