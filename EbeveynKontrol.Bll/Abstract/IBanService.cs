using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Bll.Abstract
{
    public interface IBanService
    {
        List<Ban> GetAll();
        Ban Get(int id);
        bool Add(Ban ban);
        bool Delete(Ban ban);
        bool Delete(int id);
        bool Update(Ban ban);
    }
}
