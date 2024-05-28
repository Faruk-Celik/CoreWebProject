using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Feature
{
    public class FeatureList :ViewComponent
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());        

        public IViewComponentResult Invoke ()
        {
            var values = _featureManager.TGetList();
            return View(values);
        }
    }
}
