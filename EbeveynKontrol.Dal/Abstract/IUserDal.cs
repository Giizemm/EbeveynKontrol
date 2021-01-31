using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Dal.Abstract
{
   public interface IUserDal
   {
       List<User> GetAll();
       User Get(int id);
       bool Add(User user);
       bool Delete(User user);
       bool Delete(int id);
       bool Update(User user);
   }
}
