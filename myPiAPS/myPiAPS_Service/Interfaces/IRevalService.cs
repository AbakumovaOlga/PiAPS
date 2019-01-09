using myPiAPS_Model;
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
        void CreateReval(Waybill model);

        void CreateRevalGroup(Waybill model);

        void UpdReval(Waybill model);

        void DelReval(Waybill model);

        List<Waybill> GetList();

        Waybill GetElement(int id);
    }
}
