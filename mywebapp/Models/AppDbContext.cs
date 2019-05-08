using Microsoft.EntityFrameworkCore;
using mywebapp.Models;

namespace mywebapp1.Models
{
    public class AppDbContext : DbContext
    {
        //public DbSet<RegisterInfo> RegisterInfo { get; set; }
        public DbSet<TeamRoom> TeamRooms {get; set;}
        public DbSet<User> Users{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./TMUDb.db");
        }
    }
}