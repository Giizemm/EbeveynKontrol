using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Bll.Abstract;
using EbeveynKontrol.Dal.Abstract;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Bll.Concrete
{
    public class MailManager : IMailService
    {
        private IMailDal _mailDal;

        public MailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public List<Mail> GetAll()
        {
            return _mailDal.GetAll();
        }

        public Mail Get(int id)
        {
            return _mailDal.Get(id);
        }

        public Mail FirstMail()
        {
            var mails = _mailDal.GetAll();
            return mails.FirstOrDefault();
        }

        public bool Add(Mail mail)
        {
            return _mailDal.Add(mail);
        }

        public bool Delete(Mail mail)
        {
            return _mailDal.Delete(mail);
        }

        public bool Delete(int id)
        {
            return _mailDal.Delete(id);
        }

        public bool Update(Mail mail)
        {
            return _mailDal.Update(mail);
        }
    }
}
