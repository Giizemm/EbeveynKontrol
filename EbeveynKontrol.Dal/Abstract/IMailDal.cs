using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Dal.Abstract
{
    public interface IMailDal
    {
        List<Mail> GetAll();
        Mail Get(int id);
        bool Add(Mail mail);
        bool Delete(Mail mail);
        bool Delete(int id);
        bool Update(Mail mail);
    }
}
