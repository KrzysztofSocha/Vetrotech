using Abp.AutoMapper;
using Vetrotech.Sessions.Dto;

namespace Vetrotech.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}