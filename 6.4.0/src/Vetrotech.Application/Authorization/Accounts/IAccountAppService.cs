using System.Threading.Tasks;
using Abp.Application.Services;
using Vetrotech.Authorization.Accounts.Dto;

namespace Vetrotech.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
