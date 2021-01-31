using EbeveynKontrol.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.Bll.Abstract
{
    interface IReportService
    {
        List<Report> GetAll();
        Report Get(int id);
        bool Add(Report report);
        bool Delete(Report report);
        bool Delete(int id);
        bool Update(Report report);
    }
}
