using System.Threading.Tasks;
using Modul_202107.Configuration.Dto;

namespace Modul_202107.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
