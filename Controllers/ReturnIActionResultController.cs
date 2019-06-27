using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiCore2.Services;

namespace WebApiCore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnIActionResultController : ControllerBase
    {
        [HttpGet("result-string")]
        public IActionResult ResultString()
        {
            return Ok("ok IActionResult");
        }

        [HttpGet]
        [Route("result-conditional/{id}")]
        public IActionResult ResultConditional(int id)
        {
            if(id == 1)
                return NotFound(new string[0]);
            
            return Ok(id);
        }

        [HttpGet]
        [Route("result-user")]
        public IActionResult ResultUser()
        {            
            var userService = new UserService();
            var obj = userService.GetUser();
            return Ok(obj);
        }

        [HttpGet]
        [Route("result-users")]
        public IActionResult ResultUsers()
        {            
            var userService = new UserService();
            var list = userService.GetUsers();
            if(list.ToList().Count > 0)
                return Ok(list);
            return NotFound();
        }
    }
}