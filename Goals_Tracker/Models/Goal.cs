using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goals_Tracker.Models
{
    public class Goal
    {
        [Key]
        public int GoalId { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

      
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        [MaxLength(100)]
        public string? Description { get; set; } 

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
