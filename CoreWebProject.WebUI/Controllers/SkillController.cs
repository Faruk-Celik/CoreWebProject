using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using CoreWebProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class SkillController : Controller
    {
        SkillManager SkillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index ()
        {
            ViewBag.v1 = "List Skill";
            ViewBag.v2 = "Skill";
            ViewBag.v3 = "List Skill";

            var values = SkillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill ()
        {
            ViewBag.v1 = "Add Skill";
            ViewBag.v2 = "Skill";
            ViewBag.v3 = "Add Skill";

            return View();
        }
        [HttpPost]
        public IActionResult AddSkill (Skill skill)
        {
            SkillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
    }
}
