using Abp.AspNetCore.Mvc.ViewComponents;

namespace BookManagement.Web.Views
{
    public abstract class BookManagementViewComponent : AbpViewComponent
    {
        protected BookManagementViewComponent()
        {
            LocalizationSourceName = BookManagementConsts.LocalizationSourceName;
        }
    }
}
