using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IMainService
    {
        List<ProductBM> FindProd(string number);

        List<ProductBM> Sort(int idGroup);

        void Archive();

        User Author(string login, string password);

        List<ProductBM> Less();
    }
}
