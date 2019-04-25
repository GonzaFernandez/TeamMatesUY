@using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using mywebapp.Models;

namespace mywebapp.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        public LoginController() { }

        // GET api/login
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Gets()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return "value" + id;
        }

        // POST api/login
        [HttpPost("")]
        public void Post([FromBody] string value) { }

        // PUT api/login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/login/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) { }
    }
}