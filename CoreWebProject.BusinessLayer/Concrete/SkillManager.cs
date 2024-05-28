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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager ( ISkillDal skillDal )
        {
            _skillDal = skillDal;
        }

        public void TAdd ( Skill t )
        {
            throw new NotImplementedException();
        }

        public void TDelete ( Skill t )
        {
            throw new NotImplementedException();
        }

        public Skill TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList ()
        {
            return _skillDal.GetList();
        }

        public void TUpdate ( Skill t )
        {
            throw new NotImplementedException();
        }
    }
}
