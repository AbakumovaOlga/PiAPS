using myPiAPS_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface ITypeOfWaybillService
    {
        void CreateType(TypeBM model);

        void UpdType(TypeBM model);

        void DelType(TypeBM model);

        List<TypeBM> GetList();

        TypeBM GetElement(int id);
    }
}
