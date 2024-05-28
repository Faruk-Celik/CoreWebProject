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
    public class PortfolioManager : IPortfolioSevice
    {
        private readonly IPortfolioDal _portfolioDal;

        public PortfolioManager ( IPortfolioDal portfolioDal )
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd ( Portfolio t )
        {
            throw new NotImplementedException();
        }

        public void TDelete ( Portfolio t )
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetList ()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate ( Portfolio t )
        {
            throw new NotImplementedException();
        }
    }
}
