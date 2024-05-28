using CoreWebProject.BusinessLayer.Concrete;
using CoreWebProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.WebUI.ViewComponents.Contact
{
    public class ContactDetail : ViewComponent
    {
        ContactManager _contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke ()
        {
            var contactValues = _contactManager.TGetList();
            return View(contactValues);
        }
    }
}
