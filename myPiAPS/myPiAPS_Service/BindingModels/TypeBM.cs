using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.BindingModels
{
  public class TypeBM
    {
        public int Id { get; set; }

        public string Type { get; set; }
        
        public List<Waybill> Waybills { get; set; }
    }
}
