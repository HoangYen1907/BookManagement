using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BookManagement.Controllers
{
    public abstract class BookManagementControllerBase: AbpController
    {
        protected BookManagementControllerBase()
        {
            LocalizationSourceName = BookManagementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
