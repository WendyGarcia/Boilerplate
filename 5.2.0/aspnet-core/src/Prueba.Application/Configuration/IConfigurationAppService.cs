using System.Threading.Tasks;
using Prueba.Configuration.Dto;

namespace Prueba.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
