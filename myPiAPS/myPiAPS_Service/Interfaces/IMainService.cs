using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IMainService
    {
        Product FindProd(int idProd);

        List<Product> Sort(int idGroup);

        void Archive();

        User Author(string login, string password);
    }
}
