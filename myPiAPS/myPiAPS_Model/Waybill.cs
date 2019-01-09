using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Model
{
    public class Waybill
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Customer { get; set; }

        public double Summa { get; set; }

        public double? Koef { get; set; }


        public int TypeOfWaybillId { get; set; }
        public int ShopHallId { get; set; }
        public int StockId { get; set; }

        public virtual TypeOfWaybill TypeOfWaybill { get; set; }
        public virtual ShopHall ShopHall { get; set; }
        public virtual Stock Stock { get; set; }


        [ForeignKey("WaybillId")]
        public virtual List<ProductWaybill> ProductWaybills { get; set; }
    }
}
