using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Vetrotech.MultiTenancy.Dto;

namespace Vetrotech.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
