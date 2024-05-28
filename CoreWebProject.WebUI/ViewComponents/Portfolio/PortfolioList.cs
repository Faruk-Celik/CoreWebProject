using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke ()
        {
            var portfolioValues = _portfolioManager.TGetList();
            return View(portfolioValues);
        }

    }
}
