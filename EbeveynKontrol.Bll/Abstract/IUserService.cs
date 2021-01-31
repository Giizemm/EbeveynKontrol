using EbeveynKontrol.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.Bll.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
        bool Add(User user);
        bool Delete(User user);
        bool Delete(int id);
        bool Update(User user);

        bool Login(User user);
    }
}
