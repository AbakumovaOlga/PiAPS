using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.BindingModels
{
   public  class ProductBM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mark { get; set; }

        public string Producer { get; set; }

        public string Provider { get; set; }

        public double Price { get; set; }

        public string AdvInf { get; set; }

        public string Number { get; set; }


        public int ProdGroupId { get; set; }
        
        public List<ProductWaybillBM> ProductWaybills { get; set; }

    }
}
