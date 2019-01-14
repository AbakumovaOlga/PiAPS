using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
   public  interface IProductService
    {
        void CreateProduct(ProductBM model);

        void UpdProduct(ProductBM model);

        void DelProduct(ProductBM model);

        List<ProductBM> GetList();

        ProductBM GetElement(int id);
    }
}
