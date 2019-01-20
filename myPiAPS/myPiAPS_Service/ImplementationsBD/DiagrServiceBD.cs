using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
    public class DiagrServiceBD : IDiagrService
    {
        private PiAPSDbContext context;

        public DiagrServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public double CountProdGrop(int idGroup)
        {
            double allPrice = 0;
            List<ProductBM> products=context.Products.Select(rec => new ProductBM
            {
                Id = rec.Id,
                Name = rec.Name,
                Price = rec.Price,
                ProdGroupId = rec.ProdGroupId,
                Mark = rec.Mark,
                AdvInf = rec.AdvInf,
                Producer = rec.Producer,
                Provider = rec.Provider,
                Number = rec.Number
            }).Where(recPG => recPG.ProdGroupId == idGroup)
                .ToList();
            
            foreach(ProductBM pr in products)
            {
                allPrice += pr.Price;
            }
            return allPrice;
            
        }

        public void MakeDiagr()
        {
            throw new NotImplementedException();
        }

        public void SaveDiagr()
        {
            throw new NotImplementedException();
        }
    }
}
