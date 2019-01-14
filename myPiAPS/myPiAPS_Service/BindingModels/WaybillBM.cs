using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.BindingModels
{
   public class WaybillBM
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Customer { get; set; }

        public double Summa { get; set; }

        public double? Koef { get; set; }


        public int? TypeOfWaybillId { get; set; }
        public int? ShopHallId { get; set; }
        public int? StockId { get; set; }

        public List<ProductWaybillBM> ProductWaybills { get; set; }
    }
}
