using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
   public  interface IProductService
    {
        void CreateProduct(Product model);

        void UpdProduct(Product model);

        void DelProduct(Product model);

        List<Product> GetList();

        Product GetElement(int id);
    }
}
