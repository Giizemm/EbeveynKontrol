using EbeveynKontrol.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.Bll.Abstract
{
    public interface IMailService
    {
        List<Mail> GetAll();
        Mail Get(int id);
        Mail FirstMail();
        bool Add(Mail mail);
        bool Delete(Mail mail);
        bool Delete(int id);
        bool Update(Mail mail);

    }
}
