using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Model
{
    public class TypeOfWaybill
    {
        public int Id { get; set; }

        public string Type { get; set; }


        [ForeignKey("TypeOfWaybillId")]
        public virtual List<Waybill> Waybills { get; set; }
    }
}
