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
    public class ReportManager : IReportService
    {
        private IReportDal _reportDal;
        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }
        public bool Add(Report report)
        {
            return _reportDal.Add(report);
        }

        public bool Delete(Report report)
        {
            return _reportDal.Delete(report);
        }

        public bool Delete(int id)
        {
            return _reportDal.Delete(id);
        }

        public Report Get(int id)
        {
            return _reportDal.Get(id);
        }

        public List<Report> GetAll()
        {
            return _reportDal.GetAll();
        }

        public bool Update(Report report)
        {
            return _reportDal.Update(report);
        }
    }
}
