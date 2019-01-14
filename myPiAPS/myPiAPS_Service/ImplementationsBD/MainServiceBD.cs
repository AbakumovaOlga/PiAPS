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

    public class MainServiceBD : IMainService
    {
        //private static readonly InsuranceCompanyDbContext _context = new InsuranceCompanyDbContext();
        private PiAPSDbContext context;

        public MainServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }
        private static Encoding ascii = Encoding.ASCII;

        // private static User _user;

        public void Archive()
        {
            throw new NotImplementedException();
        }

        public User Author(string login, string password)
        {

            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user == null)
            {
                throw new Exception("Введен неверный логин/пароль");
            }
            return user;
        }

        public List<ProductBM> FindProd(string idProd)
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
                    Number = rec.Number
                }).Where(recPG => recPG.Number == idProd)
                .ToList();
            return result;
        }

        public List<ProductBM> Sort(int idGroup)
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
                    Number = rec.Number
                }).Where(recPG => recPG.ProdGroupId == idGroup)
                .ToList();
            return result;
        }

        public List<ProductBM> Less()
        {
            List<ProductBM> result = new List<ProductBM>();
            List<WaybillBM> waybills = context.Waybills.Select(rec => new WaybillBM
            {
                Id = rec.Id,
                TypeOfWaybillId = rec.TypeOfWaybillId
            }).ToList();

            List<ProductBM> products = context.Products.Select(rec => new ProductBM
            {
                Id = rec.Id,
                ProdGroupId = rec.ProdGroupId,
                Name = rec.Name,
                Mark = rec.Mark,
                Producer = rec.Producer,
                Provider = rec.Provider,
                Price = rec.Price,
                AdvInf = rec.AdvInf,
                Number = rec.Number
            }).ToList();

            double SumProdictsOld = 0;
            double SumProdictsNew = 0;
            foreach (ProductBM prod in products)
            {
                int haves = 0;
                ProdGroup pg = context.ProdGroups.FirstOrDefault(rec => rec.Id == prod.ProdGroupId);
                int norm = pg.Norm;

                foreach (WaybillBM wb in waybills)
                {
                    if (wb.TypeOfWaybillId == 2)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == prod.Id)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves += p.Count;
                        }
                    }

                    if (wb.TypeOfWaybillId == 3 || wb.TypeOfWaybillId == 4)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == prod.Id)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves -= p.Count;
                        }
                    }


                }
                if (haves < norm)
                {
                    result.Add(prod);
                }
            }
            return result;
        }
    }
}
