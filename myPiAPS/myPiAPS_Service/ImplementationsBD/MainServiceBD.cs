using myPiAPS_Model;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
   public class MainServiceBD : IMainService
    {
        //private static readonly InsuranceCompanyDbContext _context = new InsuranceCompanyDbContext();
        private PiAPSDbContext context;

        public MainServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }
        private static Encoding ascii = Encoding.ASCII;

       // private static User _user;

        public void Archive()
        {
            throw new NotImplementedException();
        }

        public User Author(string login, string password)
        {

            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user == null)
            {
                throw new Exception("Введен неверный логин/пароль");
            }
            return user;
        }

        public Product FindProd(int idProd)
        {
            throw new NotImplementedException();
        }

        public List<Product> Sort(int idGroup)
        {
            throw new NotImplementedException();
        }
    }
}
