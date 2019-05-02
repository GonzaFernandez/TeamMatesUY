using System;
using System.ComponentModel.DataAnnotations;

namespace mywebapp1.Models{
    
    public class User{
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
    }
    public user(){

    }
    
}
