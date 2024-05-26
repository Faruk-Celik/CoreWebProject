﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebProject.DataAccessLayer.Abstract
{
    public interface IGenericDal <T> where T : class
    {
        void Insert ( T p );
        void Update ( T p );
        void Delete ( T p );
        List<T> GetList ();
        T GetById (int id);


    }
}
