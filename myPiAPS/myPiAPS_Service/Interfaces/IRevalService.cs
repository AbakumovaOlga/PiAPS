using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IRevalService
    {
        //Переоценка 5
        void CreateReval(WaybillBM model, double nPrice);

        void CreateRevalGroup(WaybillBM model);

        void UpdReval(WaybillBM model);

        void DelReval(WaybillBM model);

        List<WaybillBM> GetList();

        WaybillBM GetElement(int id);

        double CalcSum(WaybillBM model, double nPrice);
    }
}
