using Microsoft.AspNetCore.Antiforgery;
using BookManagement.Controllers;

namespace BookManagement.Web.Host.Controllers
{
    public class AntiForgeryController : BookManagementControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
