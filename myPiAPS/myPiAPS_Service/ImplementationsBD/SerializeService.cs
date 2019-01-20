using myPiAPS_Model;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
  public  class SerializeService :ISerializeMYService
    {
        private PiAPSDbContext context;

        public SerializeService(PiAPSDbContext context)
        {
            this.context = context;
        }

        public string GetDataFromAdmin()
        {
            DataContractJsonSerializer userJS = new DataContractJsonSerializer(typeof(List<User>));
            MemoryStream msUser = new MemoryStream();
            userJS.WriteObject(msUser, context.Users.ToList());
            msUser.Position = 0;
            StreamReader srUser = new StreamReader(msUser);
            string usersJSON = srUser.ReadToEnd();
            srUser.Close();
            msUser.Close();

            return
                "{\n" + "    \"Users\": " + usersJSON + "}";
        }

        public string GetDataFromManager()
        {
            throw new NotImplementedException();
        }

        public string GetDataFromStookKeeper(DateTime date)
        {
            DataContractJsonSerializer contractJS = new DataContractJsonSerializer(typeof(List<Waybill>));
            MemoryStream msContract = new MemoryStream();
            List<Waybill> resultContract = context.Waybills.Where(c => c.Date<date & c.TypeOfWaybillId==5).ToList();
            contractJS.WriteObject(msContract, resultContract);
            msContract.Position = 0;
            StreamReader srContract = new StreamReader(msContract);
            string contractsJSON = srContract.ReadToEnd();
            srContract.Close();
            msContract.Close();


            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    foreach (Waybill el in resultContract)
                    {

                        // удаяем записи по компонентам при удалении изделия
                        context.ProductWaybills.RemoveRange(
                                            context.ProductWaybills.Where(rec => rec.WaybillId == el.Id));
                        
                        context.Waybills.Remove(el);
                        context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }



            return
                "{\n" + "    \"Waybills\": " + contractsJSON + "}";
        }
    }
}
