using System.Threading.Tasks;
using Abp.Application.Services;
using Vetrotech.Sessions.Dto;

namespace Vetrotech.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
