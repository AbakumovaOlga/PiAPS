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
    public class StockServiceBD:IStockService
    {
        private PiAPSDbContext context;

        public StockServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateStock(StockBM model)
        {
            Stock element = context.Stocks.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть stock с таким name");
            }
            context.Stocks.Add(new Stock
            {
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void DelStock(StockBM model)
        {
            throw new NotImplementedException();
        }

        public StockBM GetElement(int id)
        {
            Stock element = context.Stocks.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new StockBM
                {
                    Id = element.Id,
                    Name = element.Name
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<StockBM> GetList()
        {
            List<StockBM> result = context.Stocks
               .Select(rec => new StockBM
               {
                   Id = rec.Id,
                   Name = rec.Name,
               })
               .ToList();
            return result;
        }

        public List<StockBM> GetListComboBox()
        {
            throw new NotImplementedException();
        }

        public void UpdStock(StockBM model)
        {
            throw new NotImplementedException();
        }
    }
}
