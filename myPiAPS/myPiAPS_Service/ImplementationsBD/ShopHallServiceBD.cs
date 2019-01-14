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
    public class ShopHallServiceBD:IShopHallService
    {
        private PiAPSDbContext context;

        public ShopHallServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateShopHall(ShopHallBM model)
        {
            ShopHall element = context.ShopHalls.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть shophall с таким name");
            }
            context.ShopHalls.Add(new ShopHall
            {
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void DelShopHall(ShopHallBM model)
        {
            throw new NotImplementedException();
        }

        public ShopHallBM GetElement(int id)
        {
            ShopHall element = context.ShopHalls.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ShopHallBM
                {
                    Id = element.Id,
                    Name = element.Name
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ShopHallBM> GetList()
        {
            List<ShopHallBM> result = context.ShopHalls
               .Select(rec => new ShopHallBM
               {
                   Id = rec.Id,
                   Name = rec.Name,
               })
               .ToList();
            return result;
        }

        public void UpdShopHall(ShopHallBM model)
        {
            throw new NotImplementedException();
        }
    }
}
