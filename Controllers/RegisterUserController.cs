using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mywebapp.Models;
using System.Web.Http;
using mywebapp1.Models;


namespace mywebapp.Controllers
{
    public class RegisterUserController: Controller
    {
        private List<RegisterInfo> listusers= new List<RegisterInfo>(); 
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm]RegisterInfo info)
        {
            using(AppDbContext db = new AppDbContext()){
                User newUser=new User();
                newUser.Name=info.FirstName;
                newUser.Birthday=info.Birthday;
                newUser.Email=info.Email;
                newUser.Password=info.Password;
                db.Users.Add(newUser);
                db.SaveChanges();
                //this.listusers.Add(model);
            }
            return RedirectToAction("Register", "RegisterUser", null);
        }
    }   
}
