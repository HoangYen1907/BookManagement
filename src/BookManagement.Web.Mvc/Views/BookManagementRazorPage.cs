using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace BookManagement.Web.Views
{
    public abstract class BookManagementRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BookManagementRazorPage()
        {
            LocalizationSourceName = BookManagementConsts.LocalizationSourceName;
        }
    }
}
