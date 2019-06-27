using System;
using System.Collections.Generic;
using WebApiCore2.Models;

namespace WebApiCore2.Services
{
    public class UserService
    {
        public User GetUser()
        {
            var user = new User();
            user.Id = 1;
            user.Name = "Sam";
            user.Date = DateTime.Now;

            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            var list = new List<User>();

            var user = new User();            
            user.Id = 1;
            user.Name = "Sam";
            user.Date = DateTime.Now;
            list.Add(user);

            user = new User();
            user.Id = 2;
            user.Name = "Ana";
            user.Date = DateTime.Now;
            list.Add(user);

            return list;
        }
    }
}