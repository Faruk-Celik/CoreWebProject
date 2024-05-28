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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager ( IServiceDal serviceDal )
        {
            _serviceDal = serviceDal;
        }

        public void TAdd ( Service t )
        {
            _serviceDal.Insert(t);
        }

        public void TDelete ( Service t )
        {
            _serviceDal.Delete(t);
        }

        public Service TGetById ( int id )
        {
            return _serviceDal.GetById(id);        }

        public List<Service> TGetList ()
        {
           return _serviceDal.GetList();
        }

        public void TUpdate ( Service t )
        {
            throw new NotImplementedException();
        }
    }
}
