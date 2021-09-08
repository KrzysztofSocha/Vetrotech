using Abp.Authorization;
using Vetrotech.Authorization.Roles;
using Vetrotech.Authorization.Users;

namespace Vetrotech.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
