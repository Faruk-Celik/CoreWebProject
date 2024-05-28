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
    public class MessageManager : IMessageService   
    {
        private readonly IMessageDal _messageDal;

        public MessageManager ( IMessageDal messageDal )
        {
            _messageDal = messageDal;
        }

        public void TAdd ( Message t )
        {
            _messageDal.Insert(t);
        }

        public void TDelete ( Message t )
        {
            throw new NotImplementedException();
        }

        public Message TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList ()
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( Message t )
        {
            throw new NotImplementedException();
        }
    }
}
