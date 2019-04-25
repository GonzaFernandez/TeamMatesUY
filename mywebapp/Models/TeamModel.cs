using system;


namespace mywebapp.Models{
    
    public class Team{
        public string name {get; set;}
        public List <User> usersList = new List<User>();
        
    }       
}
