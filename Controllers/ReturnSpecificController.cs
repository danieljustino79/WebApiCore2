using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiCore2.Models;
using WebApiCore2.Services;

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
            var userService = new UserService();
            return userService.GetUser();
        }

        

        [HttpGet]
        [Route("users")]
        public IEnumerable<User> Users()
        {
            var userService = new UserService();
            return userService.GetUsers();
        }

        [HttpGet]
        [Route("user/{id}")]
        public User UserById(int id)
        {
            return GetUserById(id);
        }

        private User GetUserById(int id)
        {
            var userService = new UserService();
            var list = userService.GetUsers();

            var obj = list.Where(x => x.Id == id).FirstOrDefault();

            return obj;
        }
    }
}