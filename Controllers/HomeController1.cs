using Microsoft.AspNetCore.Mvc;

namespace Proyecto_1_bd.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
