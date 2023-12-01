using Microsoft.AspNetCore.Mvc;

namespace Unidad_3_Actividad_1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
