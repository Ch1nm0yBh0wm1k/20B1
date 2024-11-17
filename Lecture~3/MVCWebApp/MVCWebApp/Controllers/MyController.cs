using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
