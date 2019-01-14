using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
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
        void CreateReciept(WaybillBM model);

        void UpdReciept(WaybillBM model);

        void DelReciept(WaybillBM model);

        List<WaybillBM> GetList();

        WaybillBM GetElement(int id);
    }
}
