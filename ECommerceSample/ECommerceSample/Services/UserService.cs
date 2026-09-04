using ECommerceSample.Data;
using ECommerceSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceSample.Services
{
    public class UserService
    {
        public User ValidateUser(string userName, string password)
        {
            CatalogDbContext catalogDbContext = new CatalogDbContext();
            var user = catalogDbContext.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
            return user;
        }

        public void RegisterUser(User user)
        {
            CatalogDbContext catalogDbContext = new CatalogDbContext();
            catalogDbContext.Users.Add(user);
            catalogDbContext.SaveChanges();

        }
    }
}