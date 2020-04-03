using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AD_SSO.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if (((ClaimsIdentity)User.Identity).HasClaim("role", "Administrator")) {
                return View();
            } else
            {
                return RedirectToAction("About", "Home");
            }       
        }
    }
}