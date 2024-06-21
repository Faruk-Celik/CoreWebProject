using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using CoreWebProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index ()
        {
            ViewBag.v1 = "List Experience";
            ViewBag.v2 = "Experience";
            ViewBag.v3 = "List Experience";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience )
        {
            ViewBag.v1 = "Add Experience";
            ViewBag.v2 = "Experience";
            ViewBag.v3 = "Add Experience";
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.TGetById(id);
            experienceManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = experienceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            ViewBag.v1 = "Edit Experience";
            ViewBag.v2 = "Experience";
            ViewBag.v3 = "Edit Experience";
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }

    }
}
