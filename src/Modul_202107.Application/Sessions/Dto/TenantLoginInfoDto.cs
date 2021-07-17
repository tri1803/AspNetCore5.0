using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Modul_202107.MultiTenancy;

namespace Modul_202107.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
