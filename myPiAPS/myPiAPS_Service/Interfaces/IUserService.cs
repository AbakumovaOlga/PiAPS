using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User model);

        void UpdUser(User model);

        void DelUser(User model);

        List<User> GetList();

        User GetElement(int id);
    }
}
