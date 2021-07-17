using System.Threading.Tasks;
using Abp.Application.Services;
using Modul_202107.Sessions.Dto;

namespace Modul_202107.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
