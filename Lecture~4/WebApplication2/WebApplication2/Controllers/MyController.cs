using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
