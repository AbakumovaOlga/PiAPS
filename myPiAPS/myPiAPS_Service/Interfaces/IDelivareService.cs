using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
   public interface IDelivareService
    {
        //Расход 4
        void CreateDelivare(Waybill model);

        void UpdDelivare(Waybill model);

        void DelDelivare(Waybill model);

        List<Waybill> GetList();

        Waybill GetElement(int id);
    }
}
