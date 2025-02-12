using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goals_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column (TypeName = "nvarchar(50)" )]
        public string CategoryName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; } = "";

    }
}
