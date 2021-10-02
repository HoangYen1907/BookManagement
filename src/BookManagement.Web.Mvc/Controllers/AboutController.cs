using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BookManagement.Controllers;

namespace BookManagement.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BookManagementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
