using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
    public class WaybillServiceBD : IWaybillService
    {
        private PiAPSDbContext context;

        public WaybillServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public List<WaybillBM> GetListDeliv()
        {
            List<WaybillBM> result = context.Waybills
                  .Select(rec => new WaybillBM
                  {
                      Id = rec.Id,
                      Date=rec.Date,
                      Customer=rec.Customer,
                      Summa=rec.Summa,
                      Koef=rec.Koef,
                      TypeOfWaybillId=rec.TypeOfWaybillId,
                      ShopHallId=rec.ShopHallId,
                      StockId=rec.StockId
                  }).Where(rec=>rec.TypeOfWaybillId==3)
                  .ToList();
            return result;
        }

        public List<WaybillBM> GetListToday()
        {
            List<WaybillBM> list = context.Waybills
                  .Select(rec => new WaybillBM
                  {
                      Id = rec.Id,
                      Date = rec.Date,
                      Customer = rec.Customer,
                      Summa = rec.Summa,
                      Koef = rec.Koef,
                      TypeOfWaybillId = rec.TypeOfWaybillId,
                      ShopHallId = rec.ShopHallId,
                      StockId = rec.StockId
                  })
                  .ToList();
            List<WaybillBM> result = new List<WaybillBM>();
            foreach (WaybillBM r in list)
            {
                if (r.Date.Date == DateTime.Now.Date)
                {
                    result.Add(r);
                }
            }
            return result;
        }

        public double SumDeliv(int idDeliv)
        {
            throw new NotImplementedException();
        }

        public double SumToday()
        {
            double res = 0;
            List<WaybillBM> list = context.Waybills
                   .Select(rec => new WaybillBM
                   {
                       Id = rec.Id,
                       Date = rec.Date,
                       Customer = rec.Customer,
                       Summa = rec.Summa,
                       Koef = rec.Koef,
                       TypeOfWaybillId = rec.TypeOfWaybillId,
                       ShopHallId = rec.ShopHallId,
                       StockId = rec.StockId
                   }).Where(rec=> rec.TypeOfWaybillId!=5)
                   .ToList();
            List<WaybillBM> result = new List<WaybillBM>();
            foreach (WaybillBM r in list)
            {
                if (r.Date.Date == DateTime.Now.Date)
                {
                    result.Add(r);
                }
            }
            foreach (WaybillBM wb in result)
            {
                    res += wb.Summa;
            }


            return res;
        }
    }
}
