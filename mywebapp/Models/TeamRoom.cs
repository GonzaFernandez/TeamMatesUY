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
    public class TeamRoom
    {
        public int Id{get;set;}
        public string TeamRoomName{get;set;} 
        public TeamRoom(){} 

        public TeamRoom(int teamRoomId, string teamRoomName){
            this.Id=teamRoomId;
            this.TeamRoomName=teamRoomName;
        }   
    }
}