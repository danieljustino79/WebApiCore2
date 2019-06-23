using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnSpecificController : ControllerBase
    {
        [HttpGet("string")]
        public string SpecificTypeString()
        {
            return "specific type";
        }

        [HttpGet("ienumerable-string")]
        public IEnumerable<string> IEnumerableString()
        {
            return new string[] { "simple", "get" };
        }

        [HttpGet]
        [Route("ienumerable-int")]
        public IEnumerable<int> IEnumerableInt()
        {
            return new int[] { 5, 6 , 7};
        }

        [HttpGet]
        [Route("user")]
        public User User()
        {
            return GetUser();
        }

        private User GetUser()
        {
            var user = new User();
            user.Id = 1;
            user.Name = "Sam";
            user.Date = DateTime.Now;

            return user;
        }

        [HttpGet]
        [Route("users")]
        public IEnumerable<User> Users()
        {
            return GetUsers();
        }

        private IEnumerable<User> GetUsers()
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

        [HttpGet]
        [Route("user/{id}")]
        public User UserById(int id)
        {
            return GetUserById(id);
        }

        private User GetUserById(int id)
        {
            var list = GetUsers();

            var obj = list.Where(x => x.Id == id).FirstOrDefault();

            return obj;
        }
    }

    public class User
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public DateTime Date{get;set;}
    }
}