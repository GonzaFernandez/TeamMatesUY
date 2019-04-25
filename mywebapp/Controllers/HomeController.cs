@using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using mywebapp.Models;

namespace mywebapp.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        public HomeController() { }

        // GET api/home
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Gets()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/home/5
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return "value" + id;
        }

        // POST api/home
        [HttpPost("")]
        public void Post([FromBody] string value) { }

        // PUT api/home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/home/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) { }
    }
}