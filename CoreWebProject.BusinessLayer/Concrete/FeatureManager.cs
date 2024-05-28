﻿using CoreWebProject.BusinessLayer.Abstract;
using CoreWebProject.DataAccessLayer.Abstract;
using CoreWebProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebProject.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager ( IFeatureDal featureDal )
        {
            _featureDal = featureDal;
        }

        public void TAdd ( Feature t )
        {
            _featureDal.Insert(t);        }

        public void TDelete ( Feature t )
        {
            _featureDal.Delete(t);  
        }

        public Feature TGetById ( int id )
        {
           return _featureDal.GetById(id);
        }

        public List<Feature> TGetList ()
        {
           return _featureDal.GetList();
        }

        public void TUpdate ( Feature t  )
        {
            _featureDal.Update(t);
        }
    }
}
