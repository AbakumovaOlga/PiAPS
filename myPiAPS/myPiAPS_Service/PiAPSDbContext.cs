using myPiAPS_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service
{
    [Table("PiAPSDatabase")]
    public class PiAPSDbContext :DbContext
    {
        public PiAPSDbContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<ShopHall> ShopHalls { get; set; }

        public virtual DbSet<Stock> Stocks { get; set; }

        public virtual DbSet<Waybill> Waybills { get; set; }

        public virtual DbSet<ProductWaybill> ProductWaybills { get; set; }

        public virtual DbSet<TypeOfWaybill> TypeOfWaybills { get; set; }

        public virtual DbSet<ProdGroup> ProdGroups { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}
