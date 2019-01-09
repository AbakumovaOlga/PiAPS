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
    }
}
