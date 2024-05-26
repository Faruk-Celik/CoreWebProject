using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
