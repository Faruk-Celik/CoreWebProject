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
            _skillDal.Insert(t);
        }

        public void TDelete ( Skill t )
        {
            _skillDal.Delete(t);
        }

        public Skill TGetById ( int id )
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> TGetList ()
        {
            return _skillDal.GetList();
        }

        public void TUpdate ( Skill t )
        {
            _skillDal.Update(t);    
        }
    }
}
