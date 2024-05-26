using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class DefaultControler : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
