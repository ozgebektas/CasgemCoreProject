using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ConfirmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
