using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IWaybillService
    {
        double SumToday();

        double SumDeliv(int idDeliv);

        List<WaybillBM> GetListDeliv();
        List<WaybillBM> GetListToday();

        List<WaybillBM> GetList();
        List<WaybillBM> FindWaybill(int idWaybill);
        List<WaybillBM> Sort(int idType);

        bool PrintWaybill(string path,int idWaybill);
    }
}
