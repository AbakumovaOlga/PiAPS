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
   public  class ProdGroupServiceBD :IProdGroupService
    {
        private PiAPSDbContext context;

        public ProdGroupServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateProdGroup(ProductGroupBM model)
        {
            ProdGroup element = context.ProdGroups.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть группа с таким name");
            }
            context.ProdGroups.Add(new ProdGroup
            {
                Name = model.Name,
                Norm = model.Norm
            });
            context.SaveChanges();
        }

        public void DelProdGroup(ProductGroupBM model)
        {
            throw new NotImplementedException();
        }

        public ProductGroupBM GetElement(int id)
        {
            ProdGroup element = context.ProdGroups.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ProductGroupBM
                {
                    Id = element.Id,
                    Name = element.Name,
                    Norm = element.Norm,
                    Products = element.Products
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ProductGroupBM> GetList()
        {
            List<ProductGroupBM> result = context.ProdGroups
                .Select(rec => new ProductGroupBM
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Norm = rec.Norm,
                    Products = rec.Products
                })
                .ToList();
            return result;
        }

        public List<ProductGroupBM> GetListComboBox()
        {
            List<ProductGroupBM> result = context.ProdGroups
                .Select(rec => new ProductGroupBM
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Norm = rec.Norm
                })
                .ToList();
            return result;
        }

        public void UpdProdGroup(ProductGroupBM model)
        {
            throw new NotImplementedException();
        }
    }
}
