using Microsoft.AspNetCore.Mvc;

namespace MvcMovie4.Controllers
{
    public class NuevaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
