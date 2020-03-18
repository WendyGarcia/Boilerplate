using Abp.Application.Services;
using Prueba.MultiTenancy.Dto;

namespace Prueba.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

