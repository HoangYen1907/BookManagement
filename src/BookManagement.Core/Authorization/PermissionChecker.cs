using Abp.Authorization;
using BookManagement.Authorization.Roles;
using BookManagement.Authorization.Users;

namespace BookManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
