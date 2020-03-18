using Abp.Authorization;
using Prueba.Authorization.Roles;
using Prueba.Authorization.Users;

namespace Prueba.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
