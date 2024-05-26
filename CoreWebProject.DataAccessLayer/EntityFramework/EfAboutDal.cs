using CoreWebProject.DataAccessLayer.Abstract;
using CoreWebProject.DataAccessLayer.Repositories;
using CoreWebProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebProject.DataAccessLayer.EntityFramework
{
    public class EfAboutDal :GenericRepository<About>,IAboutDal 
    {
    }
}
