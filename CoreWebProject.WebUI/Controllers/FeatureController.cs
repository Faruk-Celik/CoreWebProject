 using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
