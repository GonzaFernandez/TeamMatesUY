using System;

namespace mywebapp.Models{
    
    public class user{
        [StringLength(20)]
        [Required]
        public string name {get; set;}.
        
        [DataType(DataType.Date)]
        [Required]
        public DateTime birthday {get; set;}
        
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$")]
        public string password  {get; set;}
        
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string email {get; set;}
    }
        public user(){
        }
}
