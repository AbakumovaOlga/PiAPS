using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.BindingModels
{
   public  class ProductWaybillBM
    {
        public int Id { get; set; }

        public int Count { get; set; }


        public int ProductId { get; set; }
        public int WaybillId { get; set; }
    }
}
