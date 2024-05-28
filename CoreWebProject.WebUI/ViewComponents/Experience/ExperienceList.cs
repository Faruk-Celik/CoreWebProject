using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Experience
{
    public class ExperienceList :ViewComponent
    {
        ExperienceManager _experienceManager = new ExperienceManager (new EfExperienceDal());
        public IViewComponentResult Invoke ()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }
    }
}
