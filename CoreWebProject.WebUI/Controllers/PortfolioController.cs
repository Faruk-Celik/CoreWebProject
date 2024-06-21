using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using CoreWebProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index ()
        {
            ViewBag.v1 = "List Portfolio";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "List Portfolio";
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio )
        {
            ViewBag.v1 = "Add Portfolio";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "Add Portfolio";
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Edit Portfolio";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "Edit Portfolio";
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}
