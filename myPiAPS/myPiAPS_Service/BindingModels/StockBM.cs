using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.BindingModels
{
   public class StockBM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<WaybillBM> Waybills { get; set; }
    }
}
