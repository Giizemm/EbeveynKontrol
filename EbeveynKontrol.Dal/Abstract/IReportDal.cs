using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Dal.Abstract
{
    public interface IReportDal
    {
        List<Report> GetAll();
        Report Get(int id);
        bool Add(Report report);
        bool Delete(Report report);
        bool Delete(int id);
        bool Update(Report report);
    }
}
