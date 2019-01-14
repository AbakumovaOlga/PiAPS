using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IShopHallService
    {
        void CreateShopHall(ShopHallBM model);

        void UpdShopHall(ShopHallBM model);

        void DelShopHall(ShopHallBM model);

        List<ShopHallBM> GetList();

        ShopHallBM GetElement(int id);
    }
}
