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


namespace mywebapp.Models{
    
    public class User{
        public int Id{get;set;}

        [StringLength(20)]
        [Required(ErrorMessage = "Name is required")]
        public string Name {get; set;}

        [DataType(DataType.Date)]
        [Required (ErrorMessage = "Birthday is required")]
        public DateTime Birthday {get; set;}
        

        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$")]
        [Required(ErrorMessage = "Password is required")]
        public string Password  {get; set;}
        
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        [Required(ErrorMessage = "Email is required")]
        public string Email {get; set;}

        public List<TeamRoom> TeamRooms =new List<TeamRoom>();

        public User(){}

        public User(int id, string userName, DateTime birthday, string email, string password){
            this.Id=id;
            this.Name=userName;
            this.Birthday=birthday;
            this.Password=password;
            this.Email=email;
        }
        
    }
    
    
}