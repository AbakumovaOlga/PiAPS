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
   public  class ProductServiceBD:IProductService
    {
        private PiAPSDbContext context;

        public ProductServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateProduct(ProductBM model)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Name == model.Name|| rec.Number == model.Number);
            if (element != null)
            {
                throw new Exception("Уже есть product с таким name or number");
            }
            context.Products.Add(new Product
            {
                Name = model.Name,
                Price = model.Price,
                ProdGroupId = model.ProdGroupId,
                Mark = model.Mark,
                AdvInf=model.AdvInf,
                Producer=model.Producer,
                Provider=model.Provider,
                Number=model.Number
            });
            context.SaveChanges();
        }

        public void DelProduct(ProductBM model)
        {
            throw new NotImplementedException();
        }

        public ProductBM GetElement(int id)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ProductBM
                {
                    Id = element.Id,
                    Name = element.Name,
                    Price = element.Price,
                    ProdGroupId = element.ProdGroupId,
                    Mark = element.Mark,
                    AdvInf = element.AdvInf,
                    Producer = element.Producer,
                    Provider = element.Provider,
                    Number=element.Number
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ProductBM> GetList()
        {
            List<ProductBM> result = context.Products
                .Select(rec => new ProductBM
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Price = rec.Price,
                    ProdGroupId = rec.ProdGroupId,
                    Mark = rec.Mark,
                    AdvInf = rec.AdvInf,
                    Producer = rec.Producer,
                    Provider = rec.Provider,
                    Number=rec.Number
                })
                .ToList();
            return result;
        }

        public void UpdProduct(ProductBM model)
        {
            throw new NotImplementedException();
        }
    }
}
