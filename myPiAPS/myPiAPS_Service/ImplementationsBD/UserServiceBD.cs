﻿using myPiAPS_Model;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
    public class UserServiceBD : IUserService
    {

        private PiAPSDbContext context;

        public UserServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public void CreateUser(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Login == model.Login);
            if (element != null)
            {
                throw new Exception("Уже есть сотрудник с таким login");
            }
            context.Users.Add(new User
            {
                Login = model.Login,
                Password=model.Password,
                FIO=model.FIO,
                Role=model.Role
            });
            context.SaveChanges();
        }

        public void DelUser(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Users.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public User GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    Login = element.Login,
                    Password=element.Password,
                    FIO=element.FIO,
                    Role=element.Role
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<User> GetList()
        {
            List<User> result = context.Users
                .Select(rec => new User
                {
                    Id = rec.Id,
                    Login=rec.Login,
                    Password=rec.Password,
                    FIO=rec.FIO,
                    Role=rec.Role
                })
                .ToList();
            return result;
        }

        public void UpdUser(User model)
        {
            throw new NotImplementedException();
        }
    }
}
