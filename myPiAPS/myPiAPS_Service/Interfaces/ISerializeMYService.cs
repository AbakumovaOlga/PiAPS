using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.Interfaces
{
    public interface ISerializeMYService
    {
        string GetDataFromStookKeeper(DateTime date);

        string GetDataFromManager();

        string GetDataFromAdmin();
    }
}
