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
    public class WriteOffServiceBD : IWriteOffService
    {
        private PiAPSDbContext context;

        public WriteOffServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateWriteOff(WaybillBM model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Waybill element = new Waybill
                    {
                        Date = model.Date,
                        StockId = model.StockId,
                        TypeOfWaybillId = Convert.ToInt32(4 + ""),
                        Summa = model.Summa,
                        Customer = model.Customer
                    };
                    context.Waybills.Add(element);
                    context.SaveChanges();
                    CountOst(model);

                    // убираем дубли по компонентам
                    /* var groupProducts = model.ProductWaybills
                                                 .GroupBy(rec => rec.ProductId)
                                                 .Select(rec => new
                                                 {
                                                     ProductId = rec.Key,
                                                     Count = rec.Sum(r => r.Count)
                                                 });
                     // добавляем компоненты
                     foreach (var groupProduct in groupProducts)
                     {
                         context.ProductWaybills.Add(new ProductWaybill
                         {
                             WaybillId = element.Id,
                             ProductId = groupProduct.ProductId,
                             Count = groupProduct.Count
                         });
                         context.SaveChanges();
                     }*/
                    foreach (var ProductWaybill in model.ProductWaybills)
                    {
                        context.ProductWaybills.Add(new ProductWaybill
                        {
                            WaybillId = element.Id,
                            ProductId = ProductWaybill.ProductId,
                            Count = ProductWaybill.Count
                        });
                        context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void CountOst(WaybillBM model)
        {
            List<WaybillBM> waybills = context.Waybills.Select(rec => new WaybillBM
            {
                Id = rec.Id,
                TypeOfWaybillId = rec.TypeOfWaybillId,
                StockId=rec.StockId
            }).Where(rec => rec.StockId == model.StockId & rec.Id!=model.Id).ToList();



            foreach (var ProductWaybill in model.ProductWaybills)
            {
                int needs = ProductWaybill.Count;
                int haves = 0;

                foreach (WaybillBM wb in waybills)
                {
                    if (wb.TypeOfWaybillId == 2)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id=rec.Id,
                            ProductId=rec.ProductId,
                            WaybillId=rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach(ProductWaybillBM p in productWaybills)
                        {
                            haves += p.Count;
                        }
                    }

                    if (wb.TypeOfWaybillId == 3|| wb.TypeOfWaybillId == 4)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves -= p.Count;
                        }
                    }
                }

                if (needs > haves)
                {
                    throw new Exception("Недостаточно продукта на складе");
                }
            }
        }

        public void DelWriteOff(WaybillBM model)
        {
            throw new NotImplementedException();
        }

        public WaybillBM GetElement(int id)
        {
            throw new NotImplementedException();
        }

        public List<WaybillBM> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdWriteOff(WaybillBM model)
        {
            throw new NotImplementedException();
        }
    }
}
