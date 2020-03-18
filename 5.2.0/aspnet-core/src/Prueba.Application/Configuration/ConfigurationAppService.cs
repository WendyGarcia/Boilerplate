using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Prueba.Configuration.Dto;

namespace Prueba.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PruebaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
