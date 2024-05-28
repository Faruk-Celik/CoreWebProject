using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager _aboutManager = new AboutManager( new EfAboutDal());
        public IViewComponentResult Invoke ()
        {
            var values = _aboutManager.TGetList();
            return View(values);
        }
    }
}
