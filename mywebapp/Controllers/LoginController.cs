using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.ComponentModel.DataAnnotations;
using mywebapp1.Models;
using Microsoft.AspNetCore.Http;

namespace mywebapp1.Controllers
{

    public class LoginController : Controller
    {
        public LoginController() { }

        //[HttpGet("/Login")]
        public ActionResult<string> Login(int id){
            return View();
        }

        [ActionName ("enter")]
        [HttpPost]
        public ActionResult Login(User user) {
            
           //CONECTAR A BASE DE DATOS Y VERIFICAR SI EXISTE EL USUARIO
                //-SI -> IR A HOME PAGE
                //-NO -> IR A ERROR PAGE
            return View("Home");
         }
}
}
