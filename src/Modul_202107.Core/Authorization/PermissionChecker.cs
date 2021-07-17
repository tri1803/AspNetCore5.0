using Abp.Authorization;
using Modul_202107.Authorization.Roles;
using Modul_202107.Authorization.Users;

namespace Modul_202107.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
