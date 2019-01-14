using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.BindingModels
{
    public class ShopHallBM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
        
        public virtual List<Waybill> Waybills { get; set; }
    }
}
