using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using mywebapp1.Models;


namespace mywebapp.Models{
    [NotMapped]
    public class RegisterInfo{
        
        public int Id{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public DateTime Birthday{get;set;}
        public string Email{get;set;}
        public string TeamRoom{get;set;}
        public string Password{get;set;}
        public string ConfirmPasword{get;set;}
    }
}