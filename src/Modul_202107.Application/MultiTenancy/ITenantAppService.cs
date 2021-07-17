using Abp.Application.Services;
using Modul_202107.MultiTenancy.Dto;

namespace Modul_202107.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

