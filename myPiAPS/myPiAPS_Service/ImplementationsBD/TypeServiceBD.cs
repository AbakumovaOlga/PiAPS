using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
    public class TypeServiceBD : ITypeOfWaybillService
    {
        private PiAPSDbContext context;

        public TypeServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateType(TypeBM model)
        {
            TypeOfWaybill element = context.TypeOfWaybills.FirstOrDefault(rec => rec.Type == model.Type);
            if (element != null)
            {
                throw new Exception("Уже есть type с таким name");
            }
            context.TypeOfWaybills.Add(new TypeOfWaybill
            {
                Type = model.Type
            });
            context.SaveChanges();
        }

        public void DelType(TypeBM model)
        {
            throw new NotImplementedException();
        }

        public TypeBM GetElement(int id)
        {
            TypeOfWaybill element = context.TypeOfWaybills.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new TypeBM
                {
                    Id = element.Id,
                    Type = element.Type,
                    Waybills = element.Waybills
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<TypeBM> GetList()
        {
            List<TypeBM> result = context.TypeOfWaybills
                .Select(rec => new TypeBM
                {
                    Id = rec.Id,
                    Type = rec.Type,
                    Waybills = rec.Waybills
                })
                .ToList();
            return result;
        }

        public void UpdType(TypeBM model)
        {
            throw new NotImplementedException();
        }
    }
}
