using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mark { get; set; }

        public string Producer { get; set; }

        public string Provider { get; set; }

        public double? Price { get; set; }

        public string AdvInf { get; set; }



        public int ProdGroupId { get; set; }

        public virtual ProdGroup ProdGroup { get; set; }

        [ForeignKey("ProductId")]
        public virtual List<ProductWaybill> ProductWaybills { get; set; }
    }
}
