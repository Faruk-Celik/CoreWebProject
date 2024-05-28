using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager _skillManager = new SkillManager( new EfSkillDal());
        public IViewComponentResult Invoke ()
        {
          
            
            var skillValues = _skillManager.TGetList();
            return View(skillValues);
        }
    }
}
