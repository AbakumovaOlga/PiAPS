using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IWriteOffService
    {
        //Списать 3
        void CreateWriteOff(Waybill model);

        void UpdWriteOff(Waybill model);

        void DelWriteOff(Waybill model);

        List<Waybill> GetList();

        Waybill GetElement(int id);
    }
}
