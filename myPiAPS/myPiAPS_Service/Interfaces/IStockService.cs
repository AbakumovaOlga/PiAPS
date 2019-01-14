using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IStockService
    {
        void CreateStock(StockBM model);

        void UpdStock(StockBM model);

        void DelStock(StockBM model);

        List<StockBM> GetList();

        List<StockBM> GetListComboBox();

        StockBM GetElement(int id);
    }
}
