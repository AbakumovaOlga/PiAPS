using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Model
{
   public class Stock
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("StockId")]
        public virtual List<Waybill> Waybills { get; set; }
    }
}
