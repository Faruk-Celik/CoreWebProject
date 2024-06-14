using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PartialSidebar ()
        {
            return PartialView();
        }
        public IActionResult PartialFooter ()
        {
            return PartialView();
        }
        public IActionResult PartialNavbar ()
        {
            return PartialView();
        }
        public IActionResult PartialHead ()
        {
            return PartialView();
        }
        public IActionResult PartialScript ()
        {
            return PartialView();
        }
        public IActionResult PartialNavigation ()
        {
            return PartialView();
        }
    }
}
