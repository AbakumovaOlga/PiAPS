using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IDiagrService
    {
        void MakeDiagr();

        double CountProdGrop(int idGroup);
        void SaveDiagr();

    }
}
