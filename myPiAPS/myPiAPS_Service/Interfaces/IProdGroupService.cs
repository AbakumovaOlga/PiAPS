using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface IProdGroupService
    {
        void CreateProdGroup(ProductGroupBM model);

        void UpdProdGroup(ProductGroupBM model);

        void DelProdGroup(ProductGroupBM model);

        List<ProductGroupBM> GetList();

        List<ProductGroupBM> GetListComboBox();

        ProductGroupBM GetElement(int id);
    }
}
