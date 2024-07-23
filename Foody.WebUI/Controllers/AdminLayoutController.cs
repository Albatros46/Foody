using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
