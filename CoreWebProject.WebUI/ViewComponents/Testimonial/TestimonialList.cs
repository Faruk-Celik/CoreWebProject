using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke ()
        {
            var model = _testimonialManager.TGetList();
            return View(model);
        }

    }
}
