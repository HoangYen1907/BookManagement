using System.Threading.Tasks;
using BookManagement.Configuration.Dto;

namespace BookManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
