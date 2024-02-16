using Microsoft.AspNetCore.Mvc;

namespace Helpful.Web.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
