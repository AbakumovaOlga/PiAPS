using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IRecieptService
    {
        //Получить 2
        void CreateReciept(Waybill model);

        void UpdReciept(Waybill model);

        void DelReciept(Waybill model);

        List<Waybill> GetList();

        Waybill GetElement(int id);
    }
}
