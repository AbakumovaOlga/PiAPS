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
    public class RecieptServiceBD : IRecieptService
    {
        private PiAPSDbContext context;

        public RecieptServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateReciept(WaybillBM model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Waybill element = new Waybill
                    {
                        Date = model.Date,
                        StockId=model.StockId,
                        TypeOfWaybillId=Convert.ToInt32(2+""),
                        Summa=model.Summa
                       
                    };
                    context.Waybills.Add(element);
                    context.SaveChanges();
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

        public void DelReciept(WaybillBM model)
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

        public void UpdReciept(WaybillBM model)
        {
            throw new NotImplementedException();
        }
    }
}
