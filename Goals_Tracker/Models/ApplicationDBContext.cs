using Microsoft.EntityFrameworkCore;

namespace Goals_Tracker.Models
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext( DbContextOptions options) : base(options){ 

        }

        public DbSet <Goal> Goals { get; set; }

        public DbSet <Category> Categories { get; set; }  

    }
}
