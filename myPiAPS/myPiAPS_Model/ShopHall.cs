using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Model
{
    public class ShopHall
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("ShopHallId")]
        public virtual List<User> Users { get; set; }

        [ForeignKey("ShopHallId")]
        public virtual List<Waybill> Waybills { get; set; }
    }
}
