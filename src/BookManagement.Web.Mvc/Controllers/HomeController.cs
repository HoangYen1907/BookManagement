using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BookManagement.Controllers;

namespace BookManagement.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookManagementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
