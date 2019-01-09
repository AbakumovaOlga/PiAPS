using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Model
{
    public class ProdGroup
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Norm { get; set; }



        [ForeignKey("ProdGroupId")]
        public virtual List<Product> Products { get; set; }
    }
}
