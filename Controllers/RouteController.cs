
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "route", "class" };
        }

        [HttpGet("method")]
        public ActionResult<IEnumerable<string>> Get2()
        {
            return new string[] { "route", "class", "method" };
        }

        // GET api/values/5
        [HttpGet("method/{id}")]
        public ActionResult<string> Get3(int id)
        {
            return $"route class method param: {id}";
        }

        [HttpGet("method-int/{id:int}")] 
        public ActionResult<string> Get4(int id)
        {
            return $"route class method param int: {id}";
        }
    }
}
