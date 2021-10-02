using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BookManagement.Configuration.Dto;

namespace BookManagement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
