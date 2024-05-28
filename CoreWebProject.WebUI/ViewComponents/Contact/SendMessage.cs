using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using CoreWebProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
       MessageManager _messageManager = new MessageManager(new EfMessageDal());
      
        public IViewComponentResult Invoke ()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke (Message p)
        //{
        //    p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    _messageManager.TAdd(p);
        //    return View();
        //}
    }
}
