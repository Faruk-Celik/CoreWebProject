using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using CoreWebProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        public PartialViewResult _HeaderPartial ()
        {
            return PartialView();
        }
        public PartialViewResult _NavbarPartial ()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult _SendMessagePartial ()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult _SendMessagePartial (Message p)
        {
            MessageManager _messageManager = new MessageManager(new EfMessageDal());
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;
            _messageManager.TAdd(p);
            return PartialView();
        }
        public PartialViewResult _FooterPartial ()
        {
            return PartialView();
        }

    }
}
