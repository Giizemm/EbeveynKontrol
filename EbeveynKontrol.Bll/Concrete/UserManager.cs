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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User Get(int id)
        {
            return _userDal.Get(id);
        }

        public bool Add(User user)
        {
            return _userDal.Add(user);
        }

        public bool Delete(User user)
        {
            return _userDal.Delete(user);
        }

        public bool Delete(int id)
        {
            return _userDal.Delete(id);
        }

        public bool Update(User user)
        {
            return _userDal.Update(user);
        }

        public bool Login(User user)
        {
            var users = _userDal.GetAll();

            return users.Any(x => x.Name == user.Name && x.Password == user.Password);
        }
    }
}
