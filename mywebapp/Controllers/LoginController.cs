using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using mywebapp.Models;

namespace mywebapp.Controllers
{
    [RoutePrefix("api/[controller]")]/*<--esto causa error de namespace*/
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
        public void Post(FormCollection values) {
            var name = values["name"];
            var password = values["pass"];
            var age = 
            var userList = new List<Student>{
                new User(){name="Yhonatan", age="24", password="jhon456", email="eljhony@hotmail.com"},
                new User(){name="Brayan", age="18", password="brayan456", email="elbrayan@gmail.com"},
                new User(){name="Jesika", age="30", password="jesikca456", email="lajesika@tcs.com"},
                new User(){name="Shamila", age="25", password="shamila456", email="lashamila@hotmail.com"},
                new User(){name="Kevin", age="19", password="kevin456", email="elkevin@gmail.com"},
                new User(){name="Maykol", age="21", password="maykol456", email="elmaykol@hotmail.com"},
                new User(){name="Karlos", age="27", password="karlos456", email="elkarlos@hotmail.com"},
            };

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
