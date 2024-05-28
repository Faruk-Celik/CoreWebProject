using CoreWebProject.BusinessLayer.Abstract;
using CoreWebProject.DataAccessLayer.Abstract;
using CoreWebProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager ( IContactDal contactDal )
        {
            _contactDal = contactDal;
        }

        public void TAdd ( Contact t )
        {
            throw new NotImplementedException();
        }

        public void TDelete ( Contact t )
        {
            throw new NotImplementedException();
        }

        public Contact TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList ()
        {
            return _contactDal.GetList();
        }

        public void TUpdate ( Contact t )
        {
            throw new NotImplementedException();
        }
    }
}
