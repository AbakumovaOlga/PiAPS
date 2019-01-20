using myPiAPS_Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using myPiAPS_Service.Interfaces;
using myPiAPS_Service.ImplementationsBD;
using Unity;
using Unity.Lifetime;

namespace myPiAPS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormStart>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<DbContext, PiAPSDbContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDelivareService, DelivareServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDiagrService, DiagrServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRecieptService, RecieptServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRevalService, RevalServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWaybillService, WaybillServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMainService, MainServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWriteOffService, WriteOffServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUserService, UserServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProductService, ProductServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProdGroupService, ProdGroupServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITypeOfWaybillService, TypeServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStockService, StockServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IShopHallService, ShopHallServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ISerializeMYService, SerializeService>(new HierarchicalLifetimeManager());

            currentContainer
       .RegisterType<FormStart>()
       .RegisterInstance<IUnityContainer>(currentContainer);

            return currentContainer;
        }
    }
}
