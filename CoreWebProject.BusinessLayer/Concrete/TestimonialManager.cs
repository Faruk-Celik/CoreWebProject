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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager ( ITestimonialDal testimonialDal )
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd ( Testimonial t )
        {
            throw new NotImplementedException();
        }

        public void TDelete ( Testimonial t )
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList ()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate ( Testimonial t )
        {
            throw new NotImplementedException();
        }
    }
}
