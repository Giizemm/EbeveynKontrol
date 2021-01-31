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
    public class BanManager:IBanService
    {
        private IBanDal _banDal;

        public BanManager(IBanDal banDal)
        {
            _banDal = banDal;
        }

        public List<Ban> GetAll()
        {
            return _banDal.GetAll();
        }

        public Ban Get(int id)
        {
            return _banDal.Get(id);
        }

        public bool Add(Ban ban)
        {
            return _banDal.Add(ban);
        }

        public bool Delete(Ban ban)
        {
            return _banDal.Delete(ban);
        }

        public bool Delete(int id)
        {
            return _banDal.Delete(id);
        }

        public bool Update(Ban ban)
        {
            return _banDal.Update(ban);
        }
    }
}
