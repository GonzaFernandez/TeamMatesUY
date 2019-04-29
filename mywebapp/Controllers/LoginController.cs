@using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using mywebapp.Models;

namespace mywebapp.Controllers
{
    //[RoutePrefix("api/[controller]")]
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
        [HttpGet("/Login")]
        public ActionResult<string> GetById(int id)
        {
            return View(Login);
        }

        // POST api/login
        [ActionName("enter")]
        [HttpPost("{id}")]
        public void Post([FromBody] string value) {

            return View("Home");
         }

        // PUT api/login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {

        
         }

        // DELETE api/login/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) { }
    }
}
