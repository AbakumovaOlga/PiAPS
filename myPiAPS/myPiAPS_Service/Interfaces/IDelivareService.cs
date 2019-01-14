using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
   public interface IDelivareService
    {
        //выдача 3
        void CreateDelivare(WaybillBM model);

        void UpdDelivare(WaybillBM model);

        void DelDelivare(WaybillBM model);

        List<WaybillBM> GetList();

        WaybillBM GetElement(int id);
    }
}
