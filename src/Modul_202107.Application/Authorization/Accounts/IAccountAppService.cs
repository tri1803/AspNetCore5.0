using System.Threading.Tasks;
using Abp.Application.Services;
using Modul_202107.Authorization.Accounts.Dto;

namespace Modul_202107.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
