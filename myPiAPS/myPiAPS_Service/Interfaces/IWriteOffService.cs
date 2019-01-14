using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IWriteOffService
    {
        //Списать 4
        void CreateWriteOff(WaybillBM model);

        void UpdWriteOff(WaybillBM model);

        void DelWriteOff(WaybillBM model);

        List<WaybillBM> GetList();

        WaybillBM GetElement(int id);
    }
}
